using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using PRO1;

public class FirebaseHelper
{
    private FirebaseClient firebase;



    public FirebaseHelper()
    {
        firebase = new FirebaseClient("https://questions-sce-default-rtdb.firebaseio.com/");
    }

    public FirebaseHelper(FirebaseClient client)
    {
        firebase = client;
    }



    public async Task UpdateQuestionAsync(string key, Dictionary<string, object> data)
    {
        //var firebase = new FirebaseClient("https://questions-sce-default-rtdb.firebaseio.com/");
        await firebase.Child("questions").Child(key).PutAsync(data);
    }
    public async Task SaveExamAsync(Exam exam)
    {
        await firebase
            .Child("exams")
            .Child(exam.Id)
            .PutAsync(exam);
    }
    public async Task DeleteQuestionAsync(string questionId)
    {
        await firebase.Child("questions").Child(questionId).DeleteAsync();
    }

    public async Task SaveAdaptiveExamAsync(AdaptiveExam adaptiveExam)
    {
        await firebase
            .Child("adaptiveExams")
            .Child(adaptiveExam.Id)
            .PutAsync(adaptiveExam);
    }
    public async Task<List<Exam>> GetAllExamsAsync()
    {
        var firebaseExams = await firebase.Child("exams").OnceAsync<Exam>();
        return firebaseExams.Select(e => e.Object).ToList();
    }

    public async Task DeleteExamAsync(string examId)
    {
        await firebase.Child("exams").Child(examId).DeleteAsync();
    }

    public async Task AddUserAsync(string username, string password, string id, string email, string role)
    {
        var user = new
        {
            Username = username,
            Password = password,
            ID = id,
            Email = email,
            Role = role
        };

        await firebase
            .Child("users")
            .Child(id)
            .PutAsync(user);
    }

    public async Task DeleteUserAsync(string userId) // Use when you need to delete a specific user from the database
    {
        await firebase.Child("users").Child(userId).DeleteAsync();
    }

    public async Task SaveExamResultAsync(ExamResult result)
    {
        await firebase
            .Child($"users/{result.UserId}/grades")
            .PostAsync(result);
    }


    public async Task AddQuestionAsync(string type, string correctAnswer, string topic, string level, string questionText, string answer1, string answer2, string answer3, string answer4, string teacherId)
    {


        object question;
        Random rnd = new Random();
        int newId = rnd.Next(10000, 99999);
        string newIdString = newId.ToString();


        switch (type)
        {
            case "TrueFalse":
                question = new
                {
                    Id = newId,
                    QuestionText = questionText,
                    CorrectAnswer = correctAnswer,
                    Topic = topic,
                    Level = level,
                    Type = type,
                    TeacherId = teacherId
                };
                break;

            case "MultipleChoice":
                question = new
                {
                    Id = newId,
                    QuestionText = questionText,
                    CorrectAnswer = correctAnswer,
                    Topic = topic,
                    Level = level,
                    Answer1 = answer1,
                    Answer2 = answer2,
                    Answer3 = answer3,
                    Answer4 = answer4,
                    Type = type,
                    TeacherId = teacherId
                };
                break;

            case "FillInTheBlanks":
                question = new
                {
                    Id = newId,
                    QuestionText = questionText,
                    CorrectAnswer = correctAnswer,
                    Topic = topic,
                    Level = level,

                    Type = type,
                    TeacherId = teacherId

                };
                break;
            case "OpenQuestion":
                question = new
                {
                    Id = newId,
                    QuestionText = questionText,
                    CorrectAnswer = correctAnswer,
                    Topic = topic,
                    Level = level,
                    Type = "OpenQuestion",
                    TeacherId = teacherId
                };
                break;

            default:
                throw new ArgumentException("Unknown question type");
        }


        await firebase
                .Child("questions")
                .Child(newId.ToString())
                .PutAsync(question);
    }
    public async Task<List<Question>> GetAllQuestionsAsync()
    {
        var questions = await firebase
            .Child("questions")
            .OnceAsync<Question>();

        List<Question> result = new List<Question>();

        foreach (var item in questions)
        {
            Question q = item.Object;
            q.Id = item.Key;

            result.Add(q);
        }

        return result;
    }
    public async Task<Exam> GetExamByIdAsync(string examId)
    {
        var exam = await firebase
            .Child("exams")
            .Child(examId)
            .OnceSingleAsync<Exam>();

        return exam;
    }
    public async Task<List<(string Username, string UserId, ExamResult)>> GetAllGradesAsync()
    {
        /*
        var gradesList = new List<(string, string, ExamResult)>();

        var users = await firebase
            .Child("users")
            .OnceAsync<Dictionary<string, object>>();

        foreach (var user in users)
        {
            string userId = user.Key;
            var userData = user.Object;

            string username = userData.ContainsKey("Username") ? userData["Username"].ToString() : userId;

            var grades = await firebase
                .Child("users")
                .Child(userId)
                .Child("grades")
                .OnceAsync<ExamResult>();
            if (grades != null && grades.Count > 0)
            {

                foreach (var grade in grades)
                {

                    var exam = await GetExamByIdAsync(grade.Object.ExamId);


                    grade.Object.Subject = exam?.Topics?.FirstOrDefault() ?? "-";
                    grade.Object.Level = exam?.Difficulty ?? "-";
                    grade.Object.Score = (int)grade.Object.Grade;



                    gradesList.Add((username, userId, grade.Object));
                }
            }
        }

        return gradesList;
        */
        var gradesList = new List<(string, string, ExamResult)>();

        // Get all users from Firebase
        var users = await firebase
            .Child("users")
            .OnceAsync<Dictionary<string, object>>();

        foreach (var user in users)
        {
            string userId = user.Key;
            var userData = user.Object;

            string username = userData.ContainsKey("Username") ? userData["Username"].ToString() : userId;

            // Get grades for this user
            var grades = await firebase
                .Child("users")
                .Child(userId)
                .Child("grades")
                .OnceAsync<ExamResult>();

            if (grades != null && grades.Count > 0)
            {
                foreach (var grade in grades)
                {
                    gradesList.Add((username, userId, grade.Object));
                }
            }
        }

        return gradesList;
    }
    public async Task<List<Question>> GetQuestionsByTopicAsync(string topic)
    {
        var allQuestions = await GetAllQuestionsAsync();
        return allQuestions.Where(q => q.Topic.Equals(topic, StringComparison.OrdinalIgnoreCase)).ToList();
    }
    public async Task<List<Question>> GetQuestionsByTopicAndLevelAsync(string topic, string level)
    {
        var allQuestions = await GetAllQuestionsAsync();
        return allQuestions
            .Where(q => !string.IsNullOrEmpty(q.Topic) && !string.IsNullOrEmpty(q.Level) &&
                    q.Topic.Equals(topic, StringComparison.OrdinalIgnoreCase) &&
                    q.Level.Equals(level, StringComparison.OrdinalIgnoreCase))
        .ToList();
    }
    public async Task<List<Question>> easyQuestionsAsync()
    {
        var allQuestions = await GetAllQuestionsAsync();
        var easyQuestions = allQuestions.Where(q => q.Level.Equals("קל", StringComparison.OrdinalIgnoreCase)).ToList();
        return easyQuestions;
    }
    public async Task<List<Question>> mediumQuestionsAsync()
    {
        var allQuestions = await GetAllQuestionsAsync();
        var mediumQuestions = allQuestions.Where(q => q.Level.Equals("בינוני", StringComparison.OrdinalIgnoreCase)).ToList();
        return mediumQuestions;
    }
    public async Task<List<Question>> hardQuestionsAsync()
    {
        var allQuestions = await GetAllQuestionsAsync();
        var hardQuestions = allQuestions.Where(q => q.Level.Equals("קשה", StringComparison.OrdinalIgnoreCase)).ToList();
        return hardQuestions;
    }
    public async Task<List<ExamResult>> GetAllExamsAsync(string userId)
    {
        var results = await firebase
            .Child("users")
            .Child(userId)
            .Child("grades")
            .OnceAsync<ExamResult>();

        return results.Select(r => r.Object).ToList();
    }
    public async Task<List<Question>> GetQuestionsByTeacherIdAsync(string teacherId)
    {
        var questions = await firebase
         .Child("questions")
         .OrderBy("TeacherId")
         .EqualTo(teacherId)
         .OnceAsync<Question>();

        return questions.Select(q => q.Object).ToList();
    }
    public async Task<List<User>> GetAllUsersAsync()
    {
        var firebaseUsers = await firebase
            .Child("users")
            .OnceAsync<User>();

        List<User> users = new List<User>();

        foreach (var user in firebaseUsers)
        {
            User u = user.Object;
            u.UserId = user.Key; 
            users.Add(u);
        }

        return users;
    }

    public async Task<User> GetUserByIdAsync(string userId)
    {
        var firebaseUser = await firebase
            .Child("users")
            .Child(userId)
            .OnceSingleAsync<User>();

        return firebaseUser;
    }
    public async Task CreateUserInFirebaseAsync(User user)
    {
        await firebase
            .Child("users")
            .Child(user.UserId)
            .PutAsync(new
            {
                Username = user.Username,
                UserId = user.UserId,
                Email = user.Email,
                Role = user.Role
            });




    }
}

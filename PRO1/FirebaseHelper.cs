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

        switch (type)
        {
            case "TrueFalse":
                question = new
                {
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
                    CorrectAnswer = correctAnswer,
                    Topic = topic,
                    Level = level,
                    QuestionText = questionText,
                    Type = type,
                    TeacherId = teacherId

                };
                break;
            case "OpenQuestion":
                question = new
                {
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


        await firebase.Child("questions").PostAsync(question);
    }
    public async Task<List<Question>> GetAllQuestionsAsync()
    {
        var questions = await firebase
            .Child("questions")
            .OnceAsync<Question>();

        return questions.Select(q => q.Object).ToList();
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
            .Where(q => q.Topic.Equals(topic, StringComparison.OrdinalIgnoreCase) && q.Level.Equals(level, StringComparison.OrdinalIgnoreCase))
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
        var allQuestions = await GetAllQuestionsAsync();
        return allQuestions
            .Where(q => q.TeacherId == teacherId)
            .ToList();
    }





}

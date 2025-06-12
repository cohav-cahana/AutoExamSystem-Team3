namespace PRO1
{
    public static class AnswerSelector
    {
        public static string GetCorrectAnswer(bool[] radioChecks, string[] answers)
        {
            for (int i = 0; i < radioChecks.Length; i++)
            {
                if (radioChecks[i]) return answers[i];
            }
            return string.Empty;
        }
    }
}

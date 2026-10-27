namespace TaskModel{

    public class TaskForm{

        public int Id { get; set; }
        public string Details { get; set; }
        public string TaskText { get; set; }
        public string AnswerText { get; set; }
        public bool AnswerBool { get; set; }
        public int AnswerNum { get; set; }
    };

    // Details - справочная часть задания
    // TaskText - текст/вопрос задания
    public class ThemeRevision
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Answer_one { get; set; }
        public string Answer_two { get; set; }
        public string Answer_three { get; set; }
        public string Answer_four { get; set; }
        public string Answer_five { get; set; }
    }


}
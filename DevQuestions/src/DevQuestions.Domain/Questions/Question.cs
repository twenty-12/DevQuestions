namespace DevQuestions.Domain.Questions;

public class Question
{
    public Guid Id { get; set; }
    public required string Title { get; set; } = string.Empty;
    public required string Text { get; set; } = string.Empty;
    public required Guid UserId { get; set; }
    public Guid? ScreenshotId { get; set; }
    public List<Answer> Answers { get; set; } = new List<Answer>();
    public Answer? Solution { get; set; }
    public List<Guid> Tags { get; set; } = new List<Guid>();
}
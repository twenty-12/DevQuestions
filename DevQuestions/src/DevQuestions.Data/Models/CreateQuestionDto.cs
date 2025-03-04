namespace DevQuestions.Data.Models;

public class CreateQuestionDto
{
    public required string Title { get; set; }
    public required string Body { get; set; }
    public required Guid UserId { get; set; }
    public required Guid[] TagIds { get; set; }
}
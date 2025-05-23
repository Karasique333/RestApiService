using ToDoApp;

public static class Extensions
{
    public static TaskItemDto ToDto(this TaskItem item)
    {
        return new TaskItemDto
        {
            Id = item.Id,
            Title = item.Title,
            Description = item.Description,
            IsCompleted = item.IsCompleted
        };
    }

    public static TaskItem FromDto(this TaskItemDto dto)
    {
        return new TaskItem
        {
            Id = dto.Id,
            Title = dto.Title,
            Description = dto.Description,
            IsCompleted = dto.IsCompleted
        };
    }
}

using System.Text.Json.Serialization;

[JsonSerializable(typeof(List<TaskItem>))]
internal partial class TaskItemJsonContext : JsonSerializerContext
{
}

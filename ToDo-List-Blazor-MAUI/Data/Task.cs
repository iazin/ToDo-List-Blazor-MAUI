namespace ToDo_List_Blazor_MAUI.Data
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
    }
}

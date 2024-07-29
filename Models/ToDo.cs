namespace ToDoApp.Models
{
    public class ToDo
    {
        //Identity task.
        public int Id { get; set; }

        [Display(Name = "Title")]
        public string? Title { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Completed?")]
        public bool IsCompleted { get; set; }
    }
}

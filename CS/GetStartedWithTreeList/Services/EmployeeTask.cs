namespace GetStartedWithTreeList.Services {
    public class EmployeeTask {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string EmployeeName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Progress { get; set; }
        public EmployeeTask() { }
        public EmployeeTask(
            int id,
            int parentId,
            string name,
            string employeeName,
            DateTime startDate,
            DateTime dueDate,
            int progress
            )
        {
            Id = id;
            ParentId = parentId;
            Name = name;
            EmployeeName = employeeName;
            StartDate = startDate;
            DueDate = dueDate;
            Progress = progress;
        }
    }
}

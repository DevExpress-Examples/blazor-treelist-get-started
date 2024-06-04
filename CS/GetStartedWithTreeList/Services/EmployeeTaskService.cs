namespace GetStartedWithTreeList.Services {
    public class EmployeeTaskService {
        public List<EmployeeTask> GenerateData() {
            return new List<EmployeeTask>() {
                new EmployeeTask(1, 0, "Simplify & Clarify Product Messaging", "John Heart", new DateTime(2018, 4, 3), new DateTime(2018, 4, 14), 14),
                new EmployeeTask(2, 1, "Prepare Financial Reports", "Samantha Bright", new DateTime(2018, 4, 3), new DateTime(2018, 4, 7), 17),
                new EmployeeTask(3, 1, "Prepare Marketing Plan", "Arthur Miller", new DateTime(2018, 4, 7), new DateTime(2018, 4, 14), 11),
                new EmployeeTask(4, 0, "Create Action Plan To Improve Customer Engagement", "Robert Reagan", new DateTime(2017, 8, 8), new DateTime(2018, 4, 8), 23),
                new EmployeeTask(5, 4, "Update Personnel Files", "Greta Sims", new DateTime(2017, 8, 8), new DateTime(2017, 10, 18), 100),
                new EmployeeTask(6, 4, "Review Health Insurance Options ", "Brett Wade", new DateTime(2017, 9, 27), new DateTime(2017, 11, 10), 37),
                new EmployeeTask(7, 4, "Choose Between PPO And HMO Health Plan", "Sandra Johnson", new DateTime(2017, 12, 13), new DateTime(2018, 3, 23), 17),
                new EmployeeTask(8, 4, "Update Google Adwords Strategy", "Ed Holmes", new DateTime(2017, 8, 23), new DateTime(2017, 12, 23), 45),
                new EmployeeTask(9, 4, "Create New Brochure Design", "Barb Banks", new DateTime(2018, 1, 3), new DateTime(2018, 3, 14), 17),
                new EmployeeTask(10, 4, "Obtain Price Quote For New Brochure", "Kevin Carter", new DateTime(2018, 2, 1), new DateTime(2018, 3, 15), 18),
                new EmployeeTask(11, 4, "Brochure Design Review", "Cindy Stanwick", new DateTime(2017, 8, 22), new DateTime(2017, 10, 28), 4),
                new EmployeeTask(12, 4, "Review Website Re-Design Strategy", "Sammy Hill", new DateTime(2017, 9, 16), new DateTime(2018, 3, 6), 73),
                new EmployeeTask(13, 4, "Rollout New Website", "Davey Jones", new DateTime(2017, 11, 7), new DateTime(2018, 2, 6), 9),
                new EmployeeTask(14, 4, "Update Sales/Marketing Strategy", "Victor Norris", new DateTime(2017, 12, 13), new DateTime(2018, 4, 2), 5),
                new EmployeeTask(15, 4, "Update Sales/Revenue Report", "Mary Stern", new DateTime(2017, 12, 25), new DateTime(2018, 4, 2), 4),
                new EmployeeTask(16, 4, "Direct Vs Online Sales Comparison Report", "Robin Cosworth", new DateTime(2018, 1, 2), new DateTime(2018, 3, 20), 14),
                new EmployeeTask(17, 4, "Review Sales Report and Approve Modifications", "Kelly Rodriguez", new DateTime(2017, 9, 4), new DateTime(2017, 10, 30), 8),
                new EmployeeTask(18, 4, "Update R&D Strategy", "James Anderson", new DateTime(2017, 11, 13), new DateTime(2017, 12, 4), 12),
                new EmployeeTask(19, 4, "Discuss Updated R&D Strategy", "Antony Remmen", new DateTime(2017, 10, 29), new DateTime(2017, 12, 31), 14),
                new EmployeeTask(20, 4, "Update QA Strategy", "Olivia Peyton", new DateTime(2017, 10, 31), new DateTime(2017, 11, 2), 18),
                new EmployeeTask(21, 4, "Schedule Training Events", "Taylor Riley", new DateTime(2017, 11, 19), new DateTime(2018, 4, 7), 21),
                new EmployeeTask(22, 4, "Approve The Hiring Of John Jeffers", "Amelia Harper", new DateTime(2018, 1, 7), new DateTime(2018, 4, 8), 10),
                new EmployeeTask(23, 0, "Increase Average Subscription Price ", "Wally Hobbs", new DateTime(2017, 8, 9), new DateTime(2017, 9, 13), 96),
                new EmployeeTask(24, 23, "Update Non-Compete Agreements", "Brad Jameson", new DateTime(2017, 8, 9), new DateTime(2017, 9, 3), 96),
                new EmployeeTask(25, 23, "Update Employee Records With New NDA", "Karen Goodson", new DateTime(2017, 8, 23), new DateTime(2018, 9, 10), 100)
            };
        }
    }
}

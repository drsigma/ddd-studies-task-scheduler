namespace task_scheduler_domain.Models.Aggregates
{
    public class User
    {
        public int CPF { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public Schedule Schedule { get; private set; }
    }
}

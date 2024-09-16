using task_scheduler_application.Commands;

namespace task_scheduler_application.CommandHandler
{
    public class UserRegisterCommandHandler
    {
        public virtual async Task<LimitAllocation> Handle(RegisterUserRequest request, CancellationToken cancellationToken)
        {

        }

    }
}

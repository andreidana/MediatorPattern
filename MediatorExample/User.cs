namespace MediatorExample
{
    public abstract class User
    {
        protected Mediator.Mediator Mediator;

        protected User(Mediator.Mediator mediator)
        {
            Mediator = mediator;
        }
    }
}
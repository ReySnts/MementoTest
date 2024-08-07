public interface IContext<TStrategy>
{
    public abstract void SetStrategy(TStrategy strategy);
}
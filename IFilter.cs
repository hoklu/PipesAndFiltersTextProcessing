public interface IFilter<TInput, TOutput>
{
    TOutput Process(TInput input);
}


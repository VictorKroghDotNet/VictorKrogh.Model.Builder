namespace VictorKrogh.Model.Builder;

public abstract class EnumerableModelBuilderBase<TIn, TOut> : IEnumerableModelBuilder<TIn, TOut>
    where TOut : class, IModel
{
    public async Task<IEnumerable<TOut?>> BuildAsync(IEnumerable<TIn?> arg1)
    {
        if (arg1 == default)
        {
            return Enumerable.Empty<TOut?>();
        }

        return await BuildElementsAsync(arg1).ToListAsync();
    }

    private async IAsyncEnumerable<TOut?> BuildElementsAsync(IEnumerable<TIn?> elements)
    {
        foreach (var element in elements)
        {
            var output = await BuildAsync(element);
            if (output == default)
            {
                continue;
            }
            yield return output;
        }
    }

    public abstract Task<TOut?> BuildAsync(TIn? arg1);
}

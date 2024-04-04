namespace VictorKrogh.Model.Builder;

public interface IEnumerableModelBuilder<TIn, TOut> : IModelBuilder<TIn?, TOut> where TOut : IModel
{
    Task<IEnumerable<TOut?>> BuildAsync(IEnumerable<TIn?> arg1);
}
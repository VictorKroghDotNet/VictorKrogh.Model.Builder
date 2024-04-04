namespace VictorKrogh.Model.Builder;

public interface IModelBuilder
{
}

public interface IModelBuilder<TIn, TOut> : IModelBuilder where TOut : IModel
{
    Task<TOut?> BuildAsync(TIn? arg1);
}

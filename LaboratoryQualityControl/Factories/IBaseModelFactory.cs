namespace LaboratoryQualityControl.Factories
{
    public interface IBaseMappingFactory<TDomain,TModel>
    {
        TDomain ToDomain(TModel model);

        TModel ToModel(TDomain domain);


    }
}

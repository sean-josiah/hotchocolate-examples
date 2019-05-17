using HotChocolate.Types;

namespace Demo.Contracts
{
    public class ContractType
        : InterfaceType<IContract>
    {
        protected override void Configure(IInterfaceTypeDescriptor<IContract> descriptor)
        {
            descriptor.Name("Contract");
            descriptor.Field(t => t.Id).Type<NonNullType<IdType>>();
            descriptor.Field(t => t.CustomerId).Type<NonNullType<IdType>>();
        }
    }
}

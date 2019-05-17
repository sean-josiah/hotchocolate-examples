using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace Demo.Contracts
{
    public class LifeInsuranceContractType
        : ObjectType<LifeInsuranceContract>
    {
        private readonly IdSerializer _idSerializer = new IdSerializer();

        protected override void Configure(
            IObjectTypeDescriptor<LifeInsuranceContract> descriptor)
        {
            descriptor.Interface<ContractType>();
            descriptor.Field(t => t.Id).Type<NonNullType<IdType>>();
            descriptor.Field(t => t.CustomerId).Type<NonNullType<IdType>>()
                .Resolver(t => 
                    _idSerializer.Serialize("Customer", 
                        t.Parent<LifeInsuranceContract>().CustomerId));
        }
    }
}

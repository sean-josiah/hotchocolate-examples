using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace Demo.Contracts
{
    public class PensionPlanType
        : ObjectType<PensionPlan>
    {
        private readonly IdSerializer _idSerializer = new IdSerializer();
        
        protected override void Configure(
            IObjectTypeDescriptor<PensionPlan> descriptor)
        {
            descriptor.Interface<ContractType>();

            descriptor.Field(t => t.Id)
                .Type<NonNullType<IdType>>();

            descriptor.Field(t => t.CustomerId).Type<NonNullType<IdType>>()
                .Resolver(t => 
                    _idSerializer.Serialize("Customer",
                        t.Parent<PensionPlan>().CustomerId) );

            descriptor.Field(t => t.DueDate)
                .Type<NonNullType<DateTimeType>>();
        }
    }
}

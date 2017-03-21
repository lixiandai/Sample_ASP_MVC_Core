using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Sample.Core.Recipes.Data.Context;
using Sample.Core.Recipes.Data.Entities;
using MediatR;

namespace Sample.Core.Recipes.Application
{
    public class Index
    {
        public class Query : IRequest<Result>
        {
            public string SelectedCustomer { get; set; }
        }

        public class Result
        {
            public string SelectedCustomer { get; set; }
            public List<Customer> Customers { get; set; }

            public class Customer
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
            }
        }

        public class Handler : IAsyncRequestHandler<Query, Result>
        {
            private readonly CustomerDbContext _db;

            public Handler(CustomerDbContext db)
            {
                _db = db;
            }

            public async Task<Result> Handle(Query message)
            {
                var customers = new List<Result.Customer>
                {
                    new Result.Customer {Id = 1, Name = "MEM", Description = "Test"},
                    new Result.Customer {Id = 2, Name = "MEM2", Description = "Test"},
                    new Result.Customer {Id = 3, Name = "MEM3", Description = "Test"},
                    new Result.Customer {Id = 4, Name = "MEM4", Description = "Test"}
                };

                if (!string.IsNullOrWhiteSpace(message.SelectedCustomer))
                {
                    var membraneTypeEntities = new List<Customer>
                    {
                        new Customer {Id = 9, Name = "Puk"},
                        new Customer {Id = 10, Name = "Strepa"}
                    };

                    var listofMembraneTypes = Mapper.Map<List<Result.Customer>>(membraneTypeEntities);

                    return new Result
                    {
                        Customers = listofMembraneTypes,
                        SelectedCustomer = message.SelectedCustomer
                    };
                }

                return new Result
                {
                    Customers = customers,
                    SelectedCustomer = message.SelectedCustomer
                };
            }
        }
    }
}
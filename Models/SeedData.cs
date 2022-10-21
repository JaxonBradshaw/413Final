using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413Final.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            QuoteDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<QuoteDbContext>();

           

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Quotes.Any())
            {
                context.Quotes.AddRange(

                    new Quote
                    {
                        QuoteWords = "I'm a filler quote so that the SeedData thingy will work, woohoo!",
                        Author = "Me, Jaxon Bradshaw",
                        Date = new DateTime(2021, 04, 02),
                        Subject = "Coolology",
                        Citation = "Jaxon Bradshaw, in his apartment" //citations are dumb so I'm not going to make a real one :P
                    }
                    );
            }

        }
    }
}

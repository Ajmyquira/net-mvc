using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcDepartment.Data;
using System;
using System.Linq;

namespace MvcDepartment.Models;

public class SeedData
{
    public static void Initialize(IServiceProvider servicesProvider)
    {
        using (var context = new MvcDepartmentContext(
            servicesProvider.GetRequiredService<
                DbContextOptions<MvcDepartmentContext>>()))
        {
            // Look for any deparment
            if (context.Department.Any())
            {
                return; // DB has been seeded
            }
            context.Department.AddRange(
                new Department
                {
                    Address = "Urb. Valle Blanco III Etapa",
                    HaveGarage = false,
                    NumRooms = 5,
                    PaymentDay = DateTime.Parse("2023-9-12"),
                    Price = 7M,
                },
                new Department
                {
                    Address = "Av. Garcilazo de la Vega Nro 190",
                    HaveGarage = true,
                    NumRooms = 3,
                    PaymentDay = DateTime.Parse("2023-1-2"),
                    Price = 6M,
                },
                new Department
                {
                    Address = "Av. Caracas Mz 3 Lote M",
                    HaveGarage = false,
                    NumRooms = 3,
                    PaymentDay = DateTime.Parse("2022-3-2"),
                    Price = 5M,
                },
                new Department
                {
                    Address = "Av. Las americas Nro 89",
                    HaveGarage = true,
                    NumRooms = 5,
                    PaymentDay = DateTime.Parse("2023-3-5"),
                    Price = 6.5M,
                },
                new Department
                {
                    Address = "Av. Laykakota Mz 2 Lt. 30",
                    HaveGarage = false,
                    NumRooms = 5,
                    PaymentDay = DateTime.Parse("2020-9-15"),
                    Price = 5M,
                }
            );
            context.SaveChanges();
        }
    }
}

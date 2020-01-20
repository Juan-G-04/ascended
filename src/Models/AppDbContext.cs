using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AscendedGuild.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{			
		}

		public DbSet<PlayerClass> PlayerClasses { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Seed Player Classes
			modelBuilder.Entity<PlayerClass>().HasData(new PlayerClass
			{
				PlayerClassId = 1,
				ImageUrl = "/images/class-icons/dk.png",
				Name = "Death Knight",
				Specs = new List<Spec>(),
			});

			modelBuilder.Entity<PlayerClass>().HasData(new PlayerClass
			{
				PlayerClassId = 2,
				ImageUrl = "/images/class-icons/mage.png",
				Name = "Mage",
				Specs = new List<Spec>(),
			});

			modelBuilder.Entity<PlayerClass>().HasData(new PlayerClass
			{
				PlayerClassId = 3,
				ImageUrl = "/images/class-icons/rogue.png",
				Name = "Rogue",
				Specs = new List<Spec>(),
			});

			modelBuilder.Entity<PlayerClass>().HasData(new PlayerClass
			{
				PlayerClassId = 4,
				ImageUrl = "/images/class-icons/dh.png",
				Name = "Demon Hunter",
				Specs = new List<Spec>(),
			});

			modelBuilder.Entity<PlayerClass>().HasData(new PlayerClass
			{
				PlayerClassId = 5,
				ImageUrl = "/images/class-icons/monk.png",
				Name = "Monk",
				Specs = new List<Spec>(),
			});

			modelBuilder.Entity<PlayerClass>().HasData(new PlayerClass
			{
				PlayerClassId = 6,
				ImageUrl = "/images/class-icons/shaman.png",
				Name = "Shaman",
				Specs = new List<Spec>(),
			});

			modelBuilder.Entity<PlayerClass>().HasData(new PlayerClass
			{
				PlayerClassId = 7,
				ImageUrl = "/images/class-icons/druid.png",
				Name = "Druid",
				Specs = new List<Spec>(),
			});

			modelBuilder.Entity<PlayerClass>().HasData(new PlayerClass
			{
				PlayerClassId = 8,
				ImageUrl = "/images/class-icons/paladin.png",
				Name = "Paladin",
				Specs = new List<Spec>(),
			});

			modelBuilder.Entity<PlayerClass>().HasData(new PlayerClass
			{
				PlayerClassId = 9,
				ImageUrl = "/images/class-icons/warlock.png",
				Name = "Warlock",
				Specs = new List<Spec>(),
			});

			modelBuilder.Entity<PlayerClass>().HasData(new PlayerClass
			{
				PlayerClassId = 10,
				ImageUrl = "/images/class-icons/hunter.png",
				Name = "Hunter",
				Specs = new List<Spec>(),
			});

			modelBuilder.Entity<PlayerClass>().HasData(new PlayerClass
			{
				PlayerClassId = 11,
				ImageUrl = "/images/class-icons/priest.png",
				Name = "Priest",
				Specs = new List<Spec>(),
			});

			modelBuilder.Entity<PlayerClass>().HasData(new PlayerClass
			{
				PlayerClassId = 12,
				ImageUrl = "/images/class-icons/warrior.png",
				Name = "Warrior",
				Specs = new List<Spec>(),
			});

			// Seed Specializations
			modelBuilder.Entity<PlayerClass>().OwnsMany(c => c.Specs).HasData(
				new {
				PlayerClassId = 1,
				SpecId = Guid.NewGuid(),
				ImageUrl = "/images/class-icons/dk-blood.jpg",
				Demand = Demand.Closed,
				Name = "Blood"
				},

				new {
				PlayerClassId = 1,
				SpecId = Guid.NewGuid(),
				ImageUrl = "/images/class-icons/dk-frost.jpg",
				Demand = Demand.Closed,
				Name = "Frost"
				},
				
				new
				{
					PlayerClassId = 1,
					SpecId = Guid.NewGuid(),					
					ImageUrl = "/images/class-icons/dk-unholy.jpg",
					Demand = Demand.Closed,
					Name = "Unholy"
				},
				
				new
				{
					PlayerClassId = 2,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/mage-arcane.jpg",
					Demand = Demand.Closed,
					Name = "Arcane"
				},

				new
				{
					PlayerClassId = 2,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/mage-fire.jpg",
					Demand = Demand.Closed,
					Name = "Fire"
				},

				new
				{
					PlayerClassId = 2,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/mage-frost.jpg",
					Demand = Demand.Closed,
					Name = "Frost"
				},

				new
				{
					PlayerClassId = 3,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/rogue-assassination.jpg",
					Demand = Demand.Closed,
					Name = "Assassination"
				},

				new
				{
					PlayerClassId = 3,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/rogue-outlaw.jpg",
					Demand = Demand.Closed,
					Name = "Outlaw"
				},
				
				new
				{
					PlayerClassId = 3,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/rogue-subtlety.jpg",
					Demand = Demand.Closed,
					Name = "Subtlety"
				},

				new
				{
					PlayerClassId = 4,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/dh-havoc.jpg",
					Demand = Demand.Closed,
					Name = "Havoc"
				},

				new
				{
					PlayerClassId = 4,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/dh-vengeance.jpg",
					Demand = Demand.Closed,
					Name = "Vengeance"
				},

				new
				{
					PlayerClassId = 5,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/monk-brewmaster.jpg",
					Demand = Demand.Closed,
					Name = "Brewmaster"
				},

				new
				{
					PlayerClassId = 5,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/monk-mistweaver.jpg",
					Demand = Demand.Closed,
					Name = "Mistweaver"
				},

				new
				{
					PlayerClassId = 5,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/monk-windwalker.jpg",
					Demand = Demand.Closed,
					Name = "Windwalker"
				},

				new
				{
					PlayerClassId = 6,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/shaman-elemental.jpg",
					Demand = Demand.Closed,
					Name = "Elemental"
				},
				
				new
				{
					PlayerClassId = 6,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/shaman-enhancement.jpg",
					Demand = Demand.Closed,
					Name = "Enhancement"
				},

				new
				{
					PlayerClassId = 6,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/shaman-restoration.jpg",
					Demand = Demand.Closed,
					Name = "Restoration"
				},

				new
				{
					PlayerClassId = 7,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/druid-balance.jpg",
					Demand = Demand.Closed,
					Name = "Balance"
				},

				new
				{
					PlayerClassId = 7,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/druid-feral.jpg",
					Demand = Demand.Closed,
					Name = "Feral"
				},
				
				new
				{
					PlayerClassId = 7,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/druid-guardian.jpg",
					Demand = Demand.Closed,
					Name = "Guardian"
				},

				new
				{
					PlayerClassId = 7,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/druid-restoration.jpg",
					Demand = Demand.Closed,
					Name = "Restoration"
				},

				new
				{
					PlayerClassId = 8,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/paladin-holy.jpg",
					Demand = Demand.Closed,
					Name = "Holy"
				},

				new
				{
					PlayerClassId = 8,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/paladin-protection.jpg",
					Demand = Demand.Closed,
					Name = "Protection"
				},

				new
				{
					PlayerClassId = 8,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/paladin-retribution.jpg",
					Demand = Demand.Closed,
					Name = "Retribution"
				},

				new
				{
					PlayerClassId = 9,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/warlock-affliction.jpg",
					Demand = Demand.Closed,
					Name = "Affliction"
				},

				new
				{
					PlayerClassId = 9,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/warlock-demonology.jpg",
					Demand = Demand.Closed,
					Name = "Demonology"
				},

				new
				{
					PlayerClassId = 9,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/warlock-destruction.jpg",
					Demand = Demand.Closed,
					Name = "Destruction"
				},

				new
				{
					PlayerClassId = 10,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/hunter-bm.jpg",
					Demand = Demand.Closed,
					Name = "Beast Mastery"
				},

				new
				{
					PlayerClassId = 10,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/hunter-marksmanship.jpg",
					Demand = Demand.Closed,
					Name = "Marksmanship"
				},

				new
				{
					PlayerClassId = 10,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/hunter-survival.jpg",
					Demand = Demand.Closed,
					Name = "Survival"
				},

				new
				{
					PlayerClassId = 11,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/priest-discipline.jpg",
					Demand = Demand.Closed,
					Name = "Discipline"
				},

				new
				{
					PlayerClassId = 11,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/priest-holy.jpg",
					Demand = Demand.Closed,
					Name = "Holy"
				},

				new
				{
					PlayerClassId = 11,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/priest-shadow.jpg",
					Demand = Demand.Closed,
					Name = "Shadow"
				},

				new
				{
					PlayerClassId = 12,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/warrior-arms.jpg",
					Demand = Demand.Closed,
					Name = "Arms"
				},

				new
				{
					PlayerClassId = 12,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/warrior-fury.jpg",
					Demand = Demand.Closed,
					Name = "Fury"
				},

				new
				{
					PlayerClassId = 12,
					SpecId = Guid.NewGuid(),
					ImageUrl = "/images/class-icons/warrior-protection.jpg",
					Demand = Demand.Closed,
					Name = "Protection"
				}
			);			
		}
  }
}
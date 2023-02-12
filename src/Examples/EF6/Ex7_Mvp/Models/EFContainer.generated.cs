//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v4.2.1.3
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;

namespace Ex7_Mvp.Models
{
   /// <inheritdoc/>
   public partial class EFContainer : DbContext
   {
      #region DbSets
      public virtual System.Data.Entity.DbSet<global::Ex7_Mvp.Models.PetModel> PetModels { get; set; }
      #endregion DbSets

      #region Constructors

      partial void CustomInit();

      /// <summary>
      /// Default connection string
      /// </summary>
      public static string ConnectionString { get; set; } = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=EFVisualExamples;Integrated Security=True";
      /// <inheritdoc />
      public EFContainer() : base(ConnectionString)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFContainer>(new EFContainerDatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFContainer(string connectionString) : base(connectionString)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFContainer>(new EFContainerDatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFContainer(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFContainer>(new EFContainerDatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFContainer(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFContainer>(new EFContainerDatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFContainer(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFContainer>(new EFContainerDatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFContainer(System.Data.Entity.Infrastructure.DbCompiledModel model) : base(model)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFContainer>(new EFContainerDatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFContainer(System.Data.Entity.Core.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFContainer>(new EFContainerDatabaseInitializer());
         CustomInit();
      }

      #endregion Constructors

      partial void OnModelCreatingImpl(System.Data.Entity.DbModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(System.Data.Entity.DbModelBuilder modelBuilder);

      /// <inheritdoc />
      protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");

         modelBuilder.Entity<global::Ex7_Mvp.Models.PetModel>()
                     .ToTable("PetModels")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<global::Ex7_Mvp.Models.PetModel>()
                     .Property(t => t.Id)
                     .IsRequired()
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<global::Ex7_Mvp.Models.PetModel>()
                     .Property(t => t.Name)
                     .HasMaxLength(50);
         modelBuilder.Entity<global::Ex7_Mvp.Models.PetModel>()
                     .Property(t => t.Type)
                     .HasMaxLength(50);
         modelBuilder.Entity<global::Ex7_Mvp.Models.PetModel>()
                     .Property(t => t.Colour)
                     .HasMaxLength(50);

         OnModelCreatedImpl(modelBuilder);
      }
   }
}

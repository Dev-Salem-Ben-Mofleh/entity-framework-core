﻿// <auto-generated />
using System;
using EF_Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Core.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250304185910_RelationManyToMany")]
    partial class RelationManyToMany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_Core.Entity.BeltRank", b =>
                {
                    b.Property<int>("BeltRankID")
                        .HasColumnType("int");

                    b.Property<string>("RankName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("TestFees")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("BeltRankID");

                    b.ToTable("BeltRanks");
                });

            modelBuilder.Entity("EF_Core.Entity.BeltTest", b =>
                {
                    b.Property<int>("BeltTestID")
                        .HasColumnType("int");

                    b.Property<int>("BeltRankID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentID")
                        .HasColumnType("int");

                    b.Property<bool>("Result")
                        .HasColumnType("bit");

                    b.HasKey("BeltTestID");

                    b.HasIndex("BeltRankID");

                    b.HasIndex("InstructorID");

                    b.HasIndex("MemberID");

                    b.HasIndex("PaymentID")
                        .IsUnique()
                        .HasFilter("[PaymentID] IS NOT NULL");

                    b.ToTable("BeltTests", (string)null);
                });

            modelBuilder.Entity("EF_Core.Entity.MemberInstructor", b =>
                {
                    b.Property<int>("MemberInstructorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("AssignDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.HasKey("MemberInstructorID");

                    b.HasIndex("InstructorID");

                    b.HasIndex("MemberID");

                    b.ToTable("MemberInstructors", (string)null);
                });

            modelBuilder.Entity("EF_Core.Entity.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<byte>("PaymentFor")
                        .HasColumnType("tinyint");

                    b.HasKey("PaymentID");

                    b.HasIndex("MemberID");

                    b.ToTable("Payments", (string)null);
                });

            modelBuilder.Entity("EF_Core.Entity.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(80)
                        .HasColumnType("VARCHAR");

                    b.Property<byte>("Gender")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR");

                    b.HasKey("PersonID");

                    b.ToTable("Persons", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("EF_Core.Entity.SubscriptionPeriod", b =>
                {
                    b.Property<int>("SubscriptionPeriodID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fees")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<byte>("IssueReason")
                        .HasColumnType("tinyint");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<int?>("PaymentID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("SubscrpitonDays")
                        .HasColumnType("tinyint");

                    b.HasKey("SubscriptionPeriodID");

                    b.HasIndex("MemberID");

                    b.ToTable("SubscriptionPeriod", (string)null);
                });

            modelBuilder.Entity("EF_Core.Entity.Instructor", b =>
                {
                    b.HasBaseType("EF_Core.Entity.Person");

                    b.Property<string>("Qualification")
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("EF_Core.Entity.Member", b =>
                {
                    b.HasBaseType("EF_Core.Entity.Person");

                    b.Property<string>("EmergencyContactInfo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("LastBeltRankID")
                        .HasColumnType("int");

                    b.HasIndex("LastBeltRankID");

                    b.ToTable("Members", (string)null);
                });

            modelBuilder.Entity("EF_Core.Entity.User", b =>
                {
                    b.HasBaseType("EF_Core.Entity.Person");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<byte>("Permission")
                        .HasColumnType("tinyint");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("EF_Core.Entity.BeltTest", b =>
                {
                    b.HasOne("EF_Core.Entity.BeltRank", "BeltRank")
                        .WithMany("BeltTests")
                        .HasForeignKey("BeltRankID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Core.Entity.Instructor", "Instructor")
                        .WithMany("BeltTests")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Core.Entity.Member", "Member")
                        .WithMany("BeltTests")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Core.Entity.Payment", "Payment")
                        .WithOne("BeltTest")
                        .HasForeignKey("EF_Core.Entity.BeltTest", "PaymentID");

                    b.Navigation("BeltRank");

                    b.Navigation("Instructor");

                    b.Navigation("Member");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("EF_Core.Entity.MemberInstructor", b =>
                {
                    b.HasOne("EF_Core.Entity.Instructor", null)
                        .WithMany("MemberInstructors")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Core.Entity.Member", null)
                        .WithMany("MemberInstructors")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_Core.Entity.Payment", b =>
                {
                    b.HasOne("EF_Core.Entity.Member", "Member")
                        .WithMany("Payments")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("EF_Core.Entity.SubscriptionPeriod", b =>
                {
                    b.HasOne("EF_Core.Entity.Member", "Member")
                        .WithMany("SubscriptionPeriods")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("EF_Core.Entity.Instructor", b =>
                {
                    b.HasOne("EF_Core.Entity.Person", null)
                        .WithOne()
                        .HasForeignKey("EF_Core.Entity.Instructor", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_Core.Entity.Member", b =>
                {
                    b.HasOne("EF_Core.Entity.BeltRank", "BeltRank")
                        .WithMany("Members")
                        .HasForeignKey("LastBeltRankID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Core.Entity.Person", null)
                        .WithOne()
                        .HasForeignKey("EF_Core.Entity.Member", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BeltRank");
                });

            modelBuilder.Entity("EF_Core.Entity.User", b =>
                {
                    b.HasOne("EF_Core.Entity.Person", null)
                        .WithOne()
                        .HasForeignKey("EF_Core.Entity.User", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_Core.Entity.BeltRank", b =>
                {
                    b.Navigation("BeltTests");

                    b.Navigation("Members");
                });

            modelBuilder.Entity("EF_Core.Entity.Payment", b =>
                {
                    b.Navigation("BeltTest")
                        .IsRequired();
                });

            modelBuilder.Entity("EF_Core.Entity.Instructor", b =>
                {
                    b.Navigation("BeltTests");

                    b.Navigation("MemberInstructors");
                });

            modelBuilder.Entity("EF_Core.Entity.Member", b =>
                {
                    b.Navigation("BeltTests");

                    b.Navigation("MemberInstructors");

                    b.Navigation("Payments");

                    b.Navigation("SubscriptionPeriods");
                });
#pragma warning restore 612, 618
        }
    }
}

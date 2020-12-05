﻿// <auto-generated />
using System;
using ConsultorioGeral.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsultorioGeral.Migrations
{
    [DbContext(typeof(PacienteContext))]
    [Migration("20201202235029_alteracao_diagnotco")]
    partial class alteracao_diagnotco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ConsultorioGeral.Models.Consulta", b =>
                {
                    b.Property<long?>("ConsultaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedicoEsp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PacienteId")
                        .HasColumnType("bigint");

                    b.Property<string>("Sintomas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConsultaId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("ConsultorioGeral.Models.Diagnostico", b =>
                {
                    b.Property<long?>("DiagnosticoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("ConsultaId")
                        .HasColumnType("bigint");

                    b.HasKey("DiagnosticoId");

                    b.HasIndex("ConsultaId");

                    b.ToTable("Diagnosticos");
                });

            modelBuilder.Entity("ConsultorioGeral.Models.Medico", b =>
                {
                    b.Property<long?>("MedicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Crm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicoId");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("ConsultorioGeral.Models.Paciente", b =>
                {
                    b.Property<long?>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PacienteId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("ConsultorioGeral.Models.Consulta", b =>
                {
                    b.HasOne("ConsultorioGeral.Models.Paciente", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteId");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("ConsultorioGeral.Models.Diagnostico", b =>
                {
                    b.HasOne("ConsultorioGeral.Models.Consulta", "Consulta")
                        .WithMany("Diagnosticos")
                        .HasForeignKey("ConsultaId");

                    b.Navigation("Consulta");
                });

            modelBuilder.Entity("ConsultorioGeral.Models.Consulta", b =>
                {
                    b.Navigation("Diagnosticos");
                });

            modelBuilder.Entity("ConsultorioGeral.Models.Paciente", b =>
                {
                    b.Navigation("Consultas");
                });
#pragma warning restore 612, 618
        }
    }
}

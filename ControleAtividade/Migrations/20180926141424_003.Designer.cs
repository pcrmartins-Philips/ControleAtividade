﻿// <auto-generated />
using System;
using ControleAtividade.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleAtividade.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180926141424_003")]
    partial class _003
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview2-35157")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleAtividade.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdApplicationUser")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdApplicationUser");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("ControleAtividade.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Nome");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("TipoUsuario");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ControleAtividade.Models.Atividade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Tipo")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Atividade");
                });

            modelBuilder.Entity("ControleAtividade.Models.Atividade_Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoTurma")
                        .IsRequired();

                    b.Property<bool>("Disponivel");

                    b.Property<int>("IdAtividade");

                    b.HasKey("Id");

                    b.HasIndex("CodigoTurma");

                    b.HasIndex("IdAtividade");

                    b.ToTable("Atividade_Turma");
                });

            modelBuilder.Entity("ControleAtividade.Models.Imagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<byte[]>("ImagemBlob")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Imagem");
                });

            modelBuilder.Entity("ControleAtividade.Models.Opcao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int>("IdQuestao");

                    b.HasKey("Id");

                    b.HasIndex("IdQuestao");

                    b.ToTable("Opcao");
                });

            modelBuilder.Entity("ControleAtividade.Models.Opcao_Correta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Correta");

                    b.Property<int>("IdOpcao");

                    b.HasKey("Id");

                    b.HasIndex("IdOpcao")
                        .IsUnique();

                    b.ToTable("Opcao_Correta");
                });

            modelBuilder.Entity("ControleAtividade.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdApplicationUser")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdApplicationUser");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("ControleAtividade.Models.Questao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cabecalho")
                        .IsRequired();

                    b.Property<int>("IdAtividade");

                    b.Property<int>("IdImagem");

                    b.Property<int>("Numero");

                    b.Property<string>("Texto")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdAtividade");

                    b.ToTable("Questao");
                });

            modelBuilder.Entity("ControleAtividade.Models.Resposta_Atividade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdAluno");

                    b.Property<int>("IdAtividade_Turma");

                    b.HasKey("Id");

                    b.HasIndex("IdAluno");

                    b.ToTable("Resposta_Atividade");
                });

            modelBuilder.Entity("ControleAtividade.Models.Resposta_Opcao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdOpcao");

                    b.Property<int>("IdResposta_Atividade");

                    b.HasKey("Id");

                    b.HasIndex("IdResposta_Atividade");

                    b.ToTable("Resposta_Opcao");
                });

            modelBuilder.Entity("ControleAtividade.Models.Turma", b =>
                {
                    b.Property<string>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdProfessor");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Codigo");

                    b.HasIndex("IdProfessor");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("ControleAtividade.Models.Turma_Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoTuma")
                        .IsRequired();

                    b.Property<int>("IdAluno");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CodigoTuma");

                    b.ToTable("Turma_Aluno");
                });

            modelBuilder.Entity("ControleAtividade.Models.Usuario", b =>
                {
                    b.Property<string>("Matricula")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("UsuarioAplicacao")
                        .IsRequired();

                    b.HasKey("Matricula");

                    b.HasIndex("UsuarioAplicacao");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ControleAtividade.Models.Aluno", b =>
                {
                    b.HasOne("ControleAtividade.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("IdApplicationUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControleAtividade.Models.Atividade_Turma", b =>
                {
                    b.HasOne("ControleAtividade.Models.Turma", "Turma")
                        .WithMany()
                        .HasForeignKey("CodigoTurma")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ControleAtividade.Models.Atividade", "Atividade")
                        .WithMany()
                        .HasForeignKey("IdAtividade")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControleAtividade.Models.Opcao", b =>
                {
                    b.HasOne("ControleAtividade.Models.Questao", "Questao")
                        .WithMany("ListaOpcao")
                        .HasForeignKey("IdQuestao")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControleAtividade.Models.Opcao_Correta", b =>
                {
                    b.HasOne("ControleAtividade.Models.Opcao", "Opcao")
                        .WithOne("Opcao_Correta")
                        .HasForeignKey("ControleAtividade.Models.Opcao_Correta", "IdOpcao")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControleAtividade.Models.Professor", b =>
                {
                    b.HasOne("ControleAtividade.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("IdApplicationUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControleAtividade.Models.Questao", b =>
                {
                    b.HasOne("ControleAtividade.Models.Atividade", "Atividade")
                        .WithMany("ListaQuestao")
                        .HasForeignKey("IdAtividade")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControleAtividade.Models.Resposta_Atividade", b =>
                {
                    b.HasOne("ControleAtividade.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("IdAluno")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControleAtividade.Models.Resposta_Opcao", b =>
                {
                    b.HasOne("ControleAtividade.Models.Resposta_Atividade", "Resposta_Atividade")
                        .WithMany("ListaRespostaOpcao")
                        .HasForeignKey("IdResposta_Atividade")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControleAtividade.Models.Turma", b =>
                {
                    b.HasOne("ControleAtividade.Models.Professor", "Professor")
                        .WithMany("ListaTurma")
                        .HasForeignKey("IdProfessor")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControleAtividade.Models.Turma_Aluno", b =>
                {
                    b.HasOne("ControleAtividade.Models.Turma", "Turma")
                        .WithMany()
                        .HasForeignKey("CodigoTuma")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ControleAtividade.Models.Usuario", b =>
                {
                    b.HasOne("ControleAtividade.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UsuarioAplicacao")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ControleAtividade.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ControleAtividade.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ControleAtividade.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ControleAtividade.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

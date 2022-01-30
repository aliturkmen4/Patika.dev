using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using patika_dev;

namespace CodeFirst_patika_dev.Migrations
{
    [DbContext(typeof(PatikaDBContext))]
    partial class PatikaDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("patika_dev.Entity.Assistant", b =>
                {
                    b.Property<int>("AssistantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssistantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssistantSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssistantId");

                    b.ToTable("Assistants");
                });

            modelBuilder.Entity("patika_dev.Entity.Attendance", b =>
                {
                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AttendanceWeek8")
                        .HasColumnType("real");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("AttendanceId");

                    b.HasIndex("StudentId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("patika_dev.Entity.Education", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssistantId")
                        .HasColumnType("int");

                    b.Property<string>("EducationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartipantsId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("EducationId");

                    b.HasIndex("AssistantId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("patika_dev.Entity.EducationStudent", b =>
                {
                    b.Property<int>("BootcampStudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EducationId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("BootcampStudentId");

                    b.HasIndex("EducationId");

                    b.HasIndex("StudentId");

                    b.ToTable("BootcampStudents");
                });

            modelBuilder.Entity("patika_dev.Entity.Partipant", b =>
                {
                    b.Property<int>("PartipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("APartipantSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EducationId")
                        .HasColumnType("int");

                    b.Property<string>("PartipantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PartipantId");

                    b.HasIndex("EducationId");

                    b.ToTable("Partipants");
                });

            modelBuilder.Entity("patika_dev.Entity.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("patika_dev.Entity.Success", b =>
                {
                    b.Property<int>("SuccessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttendanceId")
                        .HasColumnType("int");

                    b.Property<float>("SuccessStatus")
                        .HasColumnType("real");

                    b.HasKey("SuccessId");

                    b.HasIndex("AttendanceId");

                    b.ToTable("Successes");
                });

            modelBuilder.Entity("patika_dev.Entity.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InstructorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstructorSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstructorId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("patika_dev.Entity.Attendance", b =>
                {
                    b.HasOne("patika_dev.Entity.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Students");
                });

            modelBuilder.Entity("patika_dev.Entity.Education", b =>
                {
                    b.HasOne("patika_dev.Entity.Assistant", "Assistants")
                        .WithMany()
                        .HasForeignKey("AssistantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("patika_dev.Entity.Teacher", "Teachers")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assistants");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("patika_dev.Entity.EducationStudent", b =>
                {
                    b.HasOne("patika_dev.Entity.Education", "Educations")
                        .WithMany()
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("patika_dev.Entity.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Educations");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("patika_dev.Entity.Partipant", b =>
                {
                    b.HasOne("patika_dev.Entity.Education", null)
                        .WithMany("Partipants")
                        .HasForeignKey("EducationId");
                });

            modelBuilder.Entity("patika_dev.Entity.Success", b =>
                {
                    b.HasOne("patika_dev.Entity.Attendance", "Attendances")
                        .WithMany()
                        .HasForeignKey("AttendanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("patika_dev.Entity.Education", b =>
                {
                    b.Navigation("Partipants");
                });
#pragma warning restore 612, 618
        }
    }
}

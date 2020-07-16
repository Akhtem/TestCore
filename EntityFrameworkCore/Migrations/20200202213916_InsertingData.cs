using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Migrations
{
    public partial class InsertingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO Course (Name,Price,CreatedOn) " +
                     "Values ('Math', 100, getdate())," +
                            "('English', 50, getdate())," +
                            "('.Net', 250, getdate())," +
                            "('The Theory of probability', 260, getdate())," +
                            "('Data Structures', 80, getdate())," +
                            "('Algorithms', 65, getdate())," +
                            "('OS', 15, getdate())");
            migrationBuilder
               .Sql("INSERT INTO DayOfWeek (Name,CreatedOn) " +
                    "Values ('Пн', getdate())," +
                           "('Вт', getdate())," +
                           "('Ср', getdate())," +
                           "('Чт', getdate())," +
                           "('Пт', getdate())");
            migrationBuilder
               .Sql("INSERT INTO TimeOfDay (Time,CreatedOn) " +
                    "Values ('09 : 00 : 00', getdate())," +
                           "('10 : 00 : 00', getdate())," +
                           "('11 : 00 : 00', getdate())," +
                           "('12 : 00 : 00', getdate())," +
                           "('13 : 00 : 00', getdate())," +
                           "('14 : 00 : 00', getdate())," +
                           "('15 : 00 : 00', getdate())," +
                           "('16 : 00 : 00', getdate())," +
                           "('17 : 00 : 00', getdate())");
            migrationBuilder
               .Sql("INSERT INTO CourseInfos (Id ,CourseId, DayOfWeekId , TimeOfDayId ,CreatedOn) " +
                    "Values (NEWID(),1, 2 ,7, getdate())," +
                           "(NEWID(),2, 1 ,6, getdate())," +
                           "(NEWID(),3, 3 ,5, getdate())," +
                           "(NEWID(),4, 4 ,4, getdate())," +
                           "(NEWID(),5, 5 ,3, getdate())," +
                           "(NEWID(),6, 1 ,2, getdate())," +
                           "(NEWID(),7, 3 ,1, getdate())," +
                           "(NEWID(),4, 4 ,7, getdate())," +
                           "(NEWID(),1, 5 ,9, getdate())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM Course");
            migrationBuilder
                .Sql("DELETE FROM DayOfWeek");
            migrationBuilder
                .Sql("DELETE FROM TimeOfDay");
            migrationBuilder
                .Sql("DELETE FROM CourseInfos");
        }
    }
}

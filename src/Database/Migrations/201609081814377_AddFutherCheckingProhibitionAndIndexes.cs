using System.Data.Entity.Migrations;

namespace Database.Migrations
{
	public partial class AddFutherCheckingProhibitionAndIndexes : DbMigration
	{
		public override void Up()
		{
			DropIndex("dbo.AutomaticExerciseCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			DropIndex("dbo.AutomaticExerciseCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			DropIndex("dbo.AutomaticExerciseCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			DropIndex("dbo.ManualExerciseCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			DropIndex("dbo.ManualExerciseCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			DropIndex("dbo.ManualExerciseCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			DropIndex("dbo.AutomaticQuizCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			DropIndex("dbo.AutomaticQuizCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			DropIndex("dbo.AutomaticQuizCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			DropIndex("dbo.ManualQuizCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			DropIndex("dbo.ManualQuizCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			DropIndex("dbo.ManualQuizCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			AddColumn("dbo.ManualExerciseCheckings", "ProhibitFurtherManualCheckings", c => c.Boolean(nullable: false));
			CreateIndex("dbo.AutomaticExerciseCheckings", new[] { "CourseId", "SlideId" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			CreateIndex("dbo.AutomaticExerciseCheckings", new[] { "CourseId", "SlideId", "Timestamp" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			CreateIndex("dbo.AutomaticExerciseCheckings", new[] { "CourseId", "SlideId", "UserId" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			CreateIndex("dbo.ManualExerciseCheckings", new[] { "CourseId", "SlideId", "UserId", "ProhibitFurtherManualCheckings" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			CreateIndex("dbo.ManualExerciseCheckings", new[] { "CourseId", "SlideId" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			CreateIndex("dbo.ManualExerciseCheckings", new[] { "CourseId", "SlideId", "Timestamp" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			CreateIndex("dbo.AutomaticQuizCheckings", new[] { "CourseId", "SlideId" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			CreateIndex("dbo.AutomaticQuizCheckings", new[] { "CourseId", "SlideId", "Timestamp" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			CreateIndex("dbo.AutomaticQuizCheckings", new[] { "CourseId", "SlideId", "UserId" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			CreateIndex("dbo.ManualQuizCheckings", new[] { "CourseId", "SlideId" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			CreateIndex("dbo.ManualQuizCheckings", new[] { "CourseId", "SlideId", "Timestamp" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			CreateIndex("dbo.ManualQuizCheckings", new[] { "CourseId", "SlideId", "UserId" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
		}

		public override void Down()
		{
			DropIndex("dbo.ManualQuizCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			DropIndex("dbo.ManualQuizCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			DropIndex("dbo.ManualQuizCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			DropIndex("dbo.AutomaticQuizCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			DropIndex("dbo.AutomaticQuizCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			DropIndex("dbo.AutomaticQuizCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			DropIndex("dbo.ManualExerciseCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			DropIndex("dbo.ManualExerciseCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			DropIndex("dbo.ManualExerciseCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			DropIndex("dbo.AutomaticExerciseCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			DropIndex("dbo.AutomaticExerciseCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			DropIndex("dbo.AutomaticExerciseCheckings", "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			DropColumn("dbo.ManualExerciseCheckings", "ProhibitFurtherManualCheckings");
			CreateIndex("dbo.ManualQuizCheckings", new[] { "SlideId", "UserId" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			CreateIndex("dbo.ManualQuizCheckings", new[] { "SlideId", "Timestamp" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			CreateIndex("dbo.ManualQuizCheckings", "SlideId", name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			CreateIndex("dbo.AutomaticQuizCheckings", new[] { "SlideId", "UserId" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			CreateIndex("dbo.AutomaticQuizCheckings", new[] { "SlideId", "Timestamp" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			CreateIndex("dbo.AutomaticQuizCheckings", "SlideId", name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			CreateIndex("dbo.ManualExerciseCheckings", new[] { "SlideId", "UserId" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			CreateIndex("dbo.ManualExerciseCheckings", new[] { "SlideId", "Timestamp" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			CreateIndex("dbo.ManualExerciseCheckings", "SlideId", name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
			CreateIndex("dbo.AutomaticExerciseCheckings", new[] { "SlideId", "UserId" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndUser");
			CreateIndex("dbo.AutomaticExerciseCheckings", new[] { "SlideId", "Timestamp" }, name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlideAndTime");
			CreateIndex("dbo.AutomaticExerciseCheckings", "SlideId", name: "IDX_AbstractSlideChecking_AbstractSlideCheckingBySlide");
		}
	}
}
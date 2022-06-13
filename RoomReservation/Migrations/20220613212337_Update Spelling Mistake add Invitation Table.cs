using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomReservation.Migrations
{
    public partial class UpdateSpellingMistakeaddInvitationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invitation_Meetings_MeetingId",
                table: "Invitation");

            migrationBuilder.DropForeignKey(
                name: "FK_Invitation_Users_UserId",
                table: "Invitation");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Rooms_RoomID",
                table: "Meetings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invitation",
                table: "Invitation");

            migrationBuilder.RenameTable(
                name: "Invitation",
                newName: "Invitations");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Rooms",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoomID",
                table: "Meetings",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Meetings_RoomID",
                table: "Meetings",
                newName: "IX_Meetings_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Invitation_UserId",
                table: "Invitations",
                newName: "IX_Invitations_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Invitation_MeetingId",
                table: "Invitations",
                newName: "IX_Invitations_MeetingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invitations",
                table: "Invitations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invitations_Meetings_MeetingId",
                table: "Invitations",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invitations_Users_UserId",
                table: "Invitations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Rooms_RoomId",
                table: "Meetings",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invitations_Meetings_MeetingId",
                table: "Invitations");

            migrationBuilder.DropForeignKey(
                name: "FK_Invitations_Users_UserId",
                table: "Invitations");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Rooms_RoomId",
                table: "Meetings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invitations",
                table: "Invitations");

            migrationBuilder.RenameTable(
                name: "Invitations",
                newName: "Invitation");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rooms",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Meetings",
                newName: "RoomID");

            migrationBuilder.RenameIndex(
                name: "IX_Meetings_RoomId",
                table: "Meetings",
                newName: "IX_Meetings_RoomID");

            migrationBuilder.RenameIndex(
                name: "IX_Invitations_UserId",
                table: "Invitation",
                newName: "IX_Invitation_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Invitations_MeetingId",
                table: "Invitation",
                newName: "IX_Invitation_MeetingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invitation",
                table: "Invitation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invitation_Meetings_MeetingId",
                table: "Invitation",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invitation_Users_UserId",
                table: "Invitation",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Rooms_RoomID",
                table: "Meetings",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "ID");
        }
    }
}

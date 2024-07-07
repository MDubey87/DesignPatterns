using StateDesignPattern.Context;

Document document = new Document();

document.Edit(); // Output: Document is in Draft state. You can edit the document.
document.Publish(); // Output: Document moved to Moderation state.

document.Edit(); // Output: Document is in Moderation state. You cannot edit the document.
document.Publish(); // Output: Document moved to Published state.

document.Edit(); // Output: Document is Published. You cannot edit the document.
document.Publish();
Console.ReadLine();
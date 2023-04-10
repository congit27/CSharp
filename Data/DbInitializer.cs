using DocumentUser.Models;

namespace DocumentUser.Data
{
    public class DbInitializer
    {
        public static void Initialize(DocumentUserContext context)
        {
            context.Database.EnsureCreated();

            // Look for any users
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User{Name="Alice", Email="alice@example.com", Password="12345"},
            new User{Name="Bob", Email="bob@example.com", Password="67890"}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var documents = new Document[]
            {
            new Document{Name="Document 1", Description="Lorem ipsum", Url="abc.com"},
            new Document{Name="Document 2", Description="Dolor sit amet", Url="abcd.com"}
            };
            foreach (Document d in documents)
            {
                context.Documents.Add(d);
            }
            context.SaveChanges();

            var userDocuments = new UserDocument[]
            {
            new UserDocument{UserId=1, DocumentId=1, CreatedAt=DateTime.Now, UpdatedAt=DateTime.Now},
            new UserDocument{UserId=2, DocumentId=2, CreatedAt=DateTime.Now, UpdatedAt=DateTime.Now},
            new UserDocument{UserId=1, DocumentId=2, CreatedAt=DateTime.Now, UpdatedAt=DateTime.Now}
            };
            foreach (UserDocument ud in userDocuments)
            {
                context.UserDocuments.Add(ud);
            }
            context.SaveChanges();
        }
    }
}

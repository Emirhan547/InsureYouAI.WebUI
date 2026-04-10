using InsureYouAI.DataAccess.Repositories.GenericRepositories;
using InsureYouAI.Entity.Entities;
using InsureYouAI.WebUI.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace InsureYouAI.DataAccess.Repositories.MessageRepositories
{
    public class MessageRepository(AppDbContext context):GenericRepository<Message>(context),IMessageRepository
    {
    }
}

using CoreProject.DataAccessLayer.Abstract;
using CoreProject.DataAccessLayer.Concrete.Repositories;
using CoreProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EfMessageBoxDal : GenericRepository<MessageBox>, IMessageBoxDal
    {
        public List<MessageBox> GetSendBoxWithMessageByWriter(int id)
        {
            using (var context=new Context())
            {
                return context.MessageBoxes.Include(x => x.ReceiverUser).Where(y => y.SenderId == id).ToList();
            }
        }

        public List<MessageBox> GetInboxWithMessageByWriter(int id)
        {
            using (var context=new Context())
            {
                return context.MessageBoxes.Include(x=>x.SenderUser).Where(x=>x.ReceiverId == id).ToList();
            }
        }
    }
}

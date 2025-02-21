using CoreProject.BusinessLayer.Abstract;
using CoreProject.DataAccessLayer.Abstract;
using CoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.BusinessLayer.Concrete
{
    public class MessageBoxManager : IMessageBoxService
    {
        IMessageBoxDal _messageBoxDal;
        public MessageBoxManager(IMessageBoxDal messageBoxDal)
        {
            _messageBoxDal = messageBoxDal;
        }
        public void Add(MessageBox entity)
        {
            _messageBoxDal.Add(entity);
        }

        public List<MessageBox> GetAll()
        {
            return _messageBoxDal.GetAll(); 
        }

        public MessageBox GetById(int id)
        {
            return _messageBoxDal.Get(id);
        }

        public List<MessageBox> GetInboxListByWriter(int id)
        {
            return _messageBoxDal.GetInboxWithMessageByWriter(id);
        }

        public List<MessageBox> GetSendBoxListByWriter(int id)
        {
            return _messageBoxDal.GetSendBoxWithMessageByWriter(id);
        }

        public void Remove(MessageBox entity)
        {
            throw new NotImplementedException();
        }

        public void Update(MessageBox entity)
        {
            throw new NotImplementedException();
        }
    }
}

using CoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.BusinessLayer.Abstract
{
    public interface IMessageBoxService:IGenericService<MessageBox>
    {
        List<MessageBox> GetInboxListByWriter(int id);
        List<MessageBox> GetSendBoxListByWriter(int id);
    }
}

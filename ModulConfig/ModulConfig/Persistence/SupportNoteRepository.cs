using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class SupportNoteRepository : RepositoryBase, IRepository<SupportNote>
    {
        private List<SupportNote> supportNotes;
        public SupportNoteRepository()
        {
            Implement();
            supportNotes = new List<SupportNote>();
        }

        public void Create(SupportNote note)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(SupportNote note)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteSupportNote", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NoteID", SqlDbType.Int).Value = note.Note_ID;
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<SupportNote> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(SupportNote note)
        {
            throw new NotImplementedException();
        }
    }
}

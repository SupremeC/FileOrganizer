using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOrganizer
{
    public class FileMoveParam
    {
        public string FolderToProcess { get; set; }
        public string SubFolderPattern { get; set; }
        public DateTime LeaveFilesNewerThen { get; set; }
        public MoveProperty MoveByProperty { get; set; }
        
    }
    public enum MoveProperty
    {
        DateModified = 1,
        DateCreated = 2
    }
}

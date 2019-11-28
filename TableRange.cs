using System;

namespace Tavisca.Applause
{
    public class TableRange
    {
        public int StartRow { get; set; }
        public int EndRow { get; set; }
        public int StartColumn { get; set; }
        public int EndColumn { get; set; }

        public TableRange()
        {
            StartRow = 1;
            EndRow = 1;
            StartColumn = 1;
            EndColumn = 1;
        }

        public TableRange(int startRow, int endRow, int startColumn, int endColumn)
        {
            StartRow = startRow == 0 ? 1 : startRow;
            StartColumn = startColumn == 0 ? 1 : startColumn;
            EndRow = endRow;
            EndColumn = endColumn;
        }

        public void ValidateRange(int numberOfRows, int numberOfColumns)
        {
            if (StartRow < 0 || StartColumn < 0)
                throw new Exception("Range not valid");
            if (EndRow > numberOfRows || EndColumn > numberOfColumns)
                throw new Exception("Range limit exceed");
            if (StartRow > EndRow || StartColumn > EndColumn)
                throw new Exception("starting index cannot be greater than ending index");
        }
    }
}

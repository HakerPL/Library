using System.Collections.Generic;
using System.Linq;
using Autofac;
using DiAutofac;
using Library.DTO;
using MySQL.Repositories;

namespace Library.Model
{
    class ConvertBookHistoryToReaderDto
    {
        public static List<ReaderHistoryDto> GetReaderHistory(int readerId)
        {
            return DiContainer.Container.Resolve<BookHistoryRepository>().GetReader(readerId).Select(b => new ReaderHistoryDto(b)).ToList();
        }
    }
}

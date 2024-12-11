using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Infrastructure.Repositories;

    public class ShelfRepository
    {
    private Context _context;
    public ShelfRepository(Context context)
    {
        _context = context;
    }
    }


﻿using System;
using System.Collections.Generic;

namespace KnowledgeApp.DataAccess.Entities;

public partial class Semester
{
    public int Id { get; set; }

    public string SemesterName { get; set; } = null!;
}

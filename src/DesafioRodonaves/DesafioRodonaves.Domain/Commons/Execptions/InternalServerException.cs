﻿using System.Net;

namespace DesafioRodonaves.Domain.Commons.Execptions;

public class InternalServerException : CustomException
{
    public InternalServerException(string message, List<string>? errors = default)
        : base(message, errors, HttpStatusCode.InternalServerError)
    {
    }

    public InternalServerException(string message, params string[] errors)
        : base(message, errors.ToList(), HttpStatusCode.InternalServerError)
    {
    }
}
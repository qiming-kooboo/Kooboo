//Copyright (c) 2018 Yardi Technology Limited. Http://www.kooboo.com
//All rights reserved.
using Kooboo.Data.Context;

namespace Kooboo.Sites.Diagnosis
{
    public interface IDiagnosis
    {
        DiagnosisSession session { get; set; }

        string Name(RenderContext context);

        string Group(RenderContext context);

        void Check();
    }
}
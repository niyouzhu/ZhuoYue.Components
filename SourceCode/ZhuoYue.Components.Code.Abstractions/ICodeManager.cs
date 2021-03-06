﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZhuoYue.Components.Code.Abstractions
{
    public interface ICodeManager
    {
        ICodeProvider CodeProvider { get; }

        IEnumerable<AppCode> ReadAll();

        AppCode ReadAll(string appId);

        CodeCategory CreateCodeCategory(CodeCategory codeCategory);

        IEnumerable<CodeCategory> CreateCodeCategory(IEnumerable<CodeCategory> codeCategories);

        IEnumerable<CodeCategory> ReadCodeCategory(SearchCriteria searchCriteria);

        CodeCategory UpdateCodeCategory(CodeCategory codeCategory);

        IEnumerable<CodeCategory> UpdateCodeCategory(IEnumerable<CodeCategory> codeCategories);
        CodeCategory DeleteCodeCategory(CodeCategory codeCategory);

        IEnumerable<CodeCategory> DeleteCodeCategory(IEnumerable<CodeCategory> codeCategories);

        CodeItem CreateCodeItem(CodeItem codeItem);
        IEnumerable<CodeItem> CreateCodeItem(IEnumerable<CodeItem> codeItems);

        CodeItem UpdateCodeItem(CodeItem codeItem);
        IEnumerable<CodeItem> UpdateCodeItem(IEnumerable<CodeItem> codeItems);
        CodeItem DeleteCodeItem(CodeItem codeItem);
        IEnumerable<CodeItem> DeleteCodeItem(IEnumerable<CodeItem> codeItems);
    }
}

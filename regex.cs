string imei_regex = @"\b(?<TAC>\d{2}[ -]?\d{6})[ -]?(?<SN>\d{6})(?<CD>\d)\b";
string internal_IP_regex = @"\b(?:10|127|172)\.(?:(?:1[6-9])|(?:2\d)|(?:3[01])|(?:192|168))\.(?:(?:25[0-5])|(?:2[0-4]\d)|(?:1\d{2,2})|(?:\d{1,2}))\.(?:(?:25[0-5])|(?:2[0-4]\d)|(?:1\d{2,2})|(?:\d{1,2}))\b";
string iban_regex = @"\b[A-Za-z]{2}\d{2}(?:(?:[ .-]?[A-Za-z\d]{4}){7}(?:[ .-]?[A-z\d]{1,2})?|(?:(?:[ .-]?[A-Za-z\d]{4}){1,6})(?:[ .-]?[A-Za-z\d]{1,3})?)\b";
string mobile_regex = @"(?:\b05\d(?:\d{7}|(?: - |[ \-])(?:\d{3}[ \-]?\d{4}|\d{4}[ \-]?\d{3}))|(?:\b972|\(972\))(?:5\d{8}|(?: - |[ \-])5\d(?:(?: - |[ \-]?)\d{7}|[ \-](?:\d{3}[ \-]\d{4}|\d{4}[ \-]\d{3}))))\b";
string landline_regex = @"(?:\b(?:0(?:7\d|[23489])(?:\d{7}|(?: - |[ \-])(?:\d{3}[ \-]?\d{4}|\d{4}[ \-]?\d{3})))|(?:(?:\b972|\(972\))(?:7\d{8}|[23489]\d{7}|[ \-](?:7\d|[23489])(?:[ \-]?\d{7}|[ \-](?:\d{3}[ \-]\d{4}|\d{4}[ \-]\d{3})))))\b";
string israel_id_regex = @"\b\d{9}\b";
string personal_regex = @"(?:(?:first|last|full|family|middle|nick|given|sur)_?name|[bi]ban|account_?(?:Id|Number)|user|birth|(?:-i:MAC)|macAddr)";
string assignes_general_personal_regex = @"(?i)(?:(?<strSym>[""\'])[\w\.\- ]*?" + personal_regex + @"[\w\.\- ]*?\k<strSym>)(: ?(?:\k<strSym>[\w\.\- ']+\k<strSym>)|\d+?)";
// Old regexes
// string methods_general_personal_regex = @"(?i)(" + personal_regex + @"[^\n]*?\((?:(?:[\s]|(?<sqb>\[)|(?<cub>\{))*?(?:\d+|(?<stringSymbol>[""\`\']{1,3})[^\n]+?\k<stringSymbol>)(?:[\s,]|(?(sqb)\]|(?(cub)\})))*?)+?\)";
// string assignes_general_personal_regex = @"(?i)(" + personal_regex + @"[^)\s]*?\s*?[=:]\s*?(\d+|(?<stringSymbol>[""\`\']{1,3})[^\n]+\k<stringSymbol>)";

# RandomTool 摇号器

## 使用方法

通过 Visual Studio 或者直接运行 `摇号器/bin/Debug/摇号器.exe` 来启动。

输入摇号范围后，点击开始摇号。工具会在随机时间内返回一个随机整数。

摇号范围默认37。

## 开发者选项

按下 <kbd>F12</kbd> 来启用开发者选项。

- Avoid list 中的号码不会被摇到。点击下方的`Save (Temporary)`临时保存。
- Certain Number 可以设定每一次摇到的数字。在右侧的输入框添加，删除，或者重新记录次数。

每次启动摇号器将读取`Options.txt`中的开发者选项配置。

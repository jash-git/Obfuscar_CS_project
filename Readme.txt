開源 C# 混淆器[obfuscar]

https://www.nuget.org/packages/Obfuscar.GlobalTool/2.2.37

教學影片: https://www.youtube.com/watch?v=DRYQIjjke5Y

教學網頁: https://www.yangyouji.info/archives/772
https://docs.obfuscar.com/getting-started/configuration#settings

自己實作步驟:
00.建立C#專案
01.使用Nuget搜尋obfuscar並安裝下列元件
	Obfuscar
	MSBuild.Obfuscar

02.專案新增Obfuscar.xml，該檔案內容如下
<?xml version="1.0" encoding="utf-8" ?>
<Obfuscator>
	<!-- 输入路径: ".\bin\x86\Debug\net6.0-windows" 該路徑是把編譯定義成x86 -->
	<Var name="InPath" value=".\bin\x86\Debug\net6.0-windows" />

	<!--输出路径:加密混淆过的路径 ; 定義在專案目錄下-->
	<Var name="OutPath" value=".\Obfuscator_Output" />

	<!--混淆代码的参数-->
	<Var name="ReuseNames" value="true" />
	<Var name="HideStrings" value="true" />
	<Var name="KeepPublicApi" value="false" />
	<Var name="HidePrivateApi" value="true" />
	<Var name="RenameProperties" value="true" />
	<Var name="RenameEvents" value="true" />
	<Var name="RenameFields" value="true" />
	<Var name="UseUnicodeNames" value="true" />
	<Var name="OptimizeMethods" value="true" />
	<Var name="SuppressIldasm" value="true" />

	<!--要混淆的模块; Obfuscar_CS_test.dll 是該專案程式碼的輸出-->
	<Module file="$(InPath)\Obfuscar_CS_test.dll" />
</Obfuscator>

03.Obfuscar.xml屬性設定永遠複製

04.在專案屬性 -> 『建置』 -> 『事件』 -> 『建置事後事件』 新增下面語法
"$(Obfuscar)" obfuscar.xml

05.測試
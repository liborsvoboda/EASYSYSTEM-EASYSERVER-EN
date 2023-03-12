## DECLARED SYSTEM CONDITIONS FOR DEVELOP NEW AGENDA
Basic Info what you minimal need for start Developing of new Agendas

1. APP Initialization [INFO]
	- Starting APP with Welcome Page by JSON Setting
	- Initialize Technologies
	- Including Core Styles and themes
	- Set Global Properties
	- Set Global DataLists  (Parameters, Setting, Tilts, System Classes, UserData, Erroer Handlers, API Security, etc)
	- Set CrashReporting join
	
1. Welcome Page [INFO] - Video Start Page with Mottos


1. NAMESPACES [CONDITIONS]
	Pages - Each Agenda must be in Namespace Pages
	Classes - All Agenda Classes are in Namespace Classes for develoer Help


1. DataClases [CONDITIONS] - DataList - Table Models Description (for Agendas/Pages)
	- Create By TemplateClass.cs file your new Class/DataModel Definition in your Agenda Folder
	- you can create Extended Table Model for more field in basic DataListModel - (example: ReceiptList, OutgoingOrderList, etc.)
	- Done

1. ApiCommunications [CONDITIONS] - In the Class is in ENUM all API address list
	- All API Cals  which has 'List' word on End is automatically supported for insert Report
	- Insert your New API address to this enum
	- Done
	
1. Languages [CONDITIONS] - Each used 'Word' must exist in all Language Files Before Build 
	- insert all new translations [check duplicity]to all dictionaries for your new Agenda field, menuName
	- Done

1. PageTemplatesCodeHelp [INFO] - is centralised List of special methods in the system (Load/SaveFile, load, lang, number validation, etc..)


1. Templates [INFO]  - For simple create new ANY agengas by COPY/PASTE for simple modify INPUT fields only
	- for new Agenda Create new folder in Agendas and copy TemplateClass and correct TemplatePage to this folder
	- rename these files and change class model to your new class[COPY/PASTE from backend]
	- replace 'TemplateClass' for your new in XAML and CS file of your new Page/Agenda
	- now the form field change only and modify and check fields, translations, apiCalls in cs code for your new
	- Done
	

1. MainMenu [CONDITIONS]  - in MainWindow must be new agenga inserted to the application menu
    - Insert new menu Item -im Xaml copy existing menu item and rename to your new Agenda   
    - Translate menu item - In CS code insert the translate menu item in initialize Method
    - Set Menu Reaction - in MainWindows Method 'Cb_verticalMenuSelected' copy existing menuitem part code inthe 'CASE' and change XAML menu name and name of called 'Page'
      Here on end case for List Report set the '/YourTableNameList' in Report line 
      or for non report Table set 'cb_printReports.ItemsSource = null;'
	- Done
	
1. Reports [INFO] - In system menu Reports you can upload Report file for your new Agenda 

NOW Build and YOUR new Agenda is IN App Menu and After click is oppened
**THIS IS ALL INFORMATIONS FOR SUCCESS DEVELOPING**

## SHORT SYSTEM DESCRIPTION

	System is Fully dynamic Controlled For All menuInserted Pages/Agendas 
	(Insert new Page/Agenda to menu + Translate for implement to full system only)

	All method are implemented with global logic of using for centralised Core of this System and his Modification
	For working with any standard system agenda (Typicaly IS System - SAP Example) 

	INSERT/UPDATE/DELETE/SELECT/FILTER/PRINT/SHOW/MEDIA 3D/VIDEO/DOCS/EAN CODES/1000 FINISHED TOOLS on GITHUB/UNLIMITED ETC

	FOR WINDOWS MODERN SYSTEMS/TERMINALS/ETC ON START (WEB FORMAT IS SUPPORTED BY TECHNOLOGY WILL BE DONE IN YEAR FUTURE




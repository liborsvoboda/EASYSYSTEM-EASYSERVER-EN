## MAINWINDOW Central SYSTEM Control Manual
This is Core central point (MainWindow.xaml/cs) for full system
Here are Defined All join for Central Control for All parts of System
 
- MainWindow is Absolut Primary Control window off all actions in the application 
- Here are All global definitions, Messages, mainWindows and all Shared Controls for Pages
- Here are Application Menu events, Update, Reports, New/Edit/.. for Datalist, Filters, TabPages
- MainWindow Has Defined 3Menu Types for More Systems: 
       - Buttons in Header LINE -> For simple touch Terminal with few button for Agendas
       - SelectBox -> For TouchPanels with more MenuItems, but Touch functionality is Needed
       - TreeView -> For Robust Systems with a lot of MenuItems/Agendas
- in Xaml are declared all shared input/Controls/ETC for Application  
  App Update, Tools, Theme, Menus, Report Ctrl, Pages Controls, Graphics, ProgressRing, Tabpages Types, 

  



## IMPORTANT METHOD LIST SYSTEM CORE

---
**CORE SYSTEM METHODS**
- Initialize - Initiate Theme/Color/App menu/Load Config/Show Login   
 **Here is Translate Menu Items**
  
- Timer10sec_Elapsed - Auto Backend Timer cycling by Config [default 5sec]
    - check if Backend is Accesible - Server status Control
    - load Server Setting
    - Load Application Parameters for NULL user
    
- ShowLoginDialog - Login, Load User Params, Token, Enable Menu Items  
- ShowMessage - Shared Message for call from Pages For show in MainWindow  
- SetServiceStop - connect/disconnect menuItems Pages on Backend Service Status

---
**DATALIST GLOBAL METHODS**
- cb_FilterDropDownClosed - Reload Datalist with filtering
- Mi_filter_Click - Generate and show advanced filter (for SQL conditioning): 
- Cb_PrintReportsSelected - save fitler to DB, open selected Report
- Cb_verticalMenuSelected - Open selected Page/Agenda and set all controls,input,filter,reports status 
  **!!NEW AGENDA MUST BE DEFINED ONLY HERE.**
 

## INFO METHOD LIST SYSTEM CORE NOT NEEDED CHANGES
- Btn_about_click - Show About Info  
- WinMain_KeyDown - Global Control for Keyboard press ,implemented F1/ALT+Q

- Btn_LaunchHelp_Click - Open index.chm Windows Help File
- ApplicationClosing - Save theme, close App
- AppRestart - Restart for Configuration Reload
- StringToFilter - upload setted filter in page for actual view
- RemoveFilterItem_Click - Remove advanced filter Item
- FilterField_SelectionChanged - support methos for dynamic filter generation
- MainGrid_IsDraggingChanged - For Draging TabPages - ACTUALLY DISABLED
- Menu_action_Click - Automatic Datalist Controls Action Handler
- AddNewTab - Automatic TabPages Controller
- TabPanelOnSelectionChange - Automatic Controller for TabPages Changing
- ChangeMenuView - Specific for Version with more menu types. Show/Hide used menu type


### PAGE/AGENDA STANDARTIZED DEFINITION FOR CREATE NEW ANY SYSTEM STANDARD AGENGA

	AGENDA (Page) IS BUILDED FROM STANDARTIZED METHODS FOR FULL CONTROL OF EACH STANDARD Agenda Page
		   Each FULL agenga has these Methods for work with SYSTEM CORE

	AGENDA CONTAIN - DaTaModel Class File (Copied from Backend Server or DB Structure ScaffoldContext)
					 PreDefined XAML FORM (contain both LIST/FORM definitions) 
					 List od Global System Methods for Control Full Agenda in System Core

	PAGE - AGENDA METHOD LIST
		Method InitializePage       - used by MenuClick - Load Dictionaries, Parameters, Translate Form Fields And Run 'LoadDataList' for Datalist/Dials, others, Set Record = False
		Method LoadDataList         - used by REFRESH Button - Call API for again load datasets in Page (DB Select)
		Method NewRecord            - used by NEW Button     - Open detail form for New Record
		Method EditRecord(false)    - used by EDIT Button    - Open detail form for edit Record
		Method EditRecord(true)     - used by COPY Button    - Open detail form for create copied Record (with ID=0)
		Method DeleteRecord         - used by DELETE Button  - Call delete API for selected record in datalist (DB Delete)

		Method Filter               - SEARCH Textox - SIMPLE SEARCH in all defined columns in PAGE code - Method Filter
		Method DgListView_Translate - Translate Datalist colum - translate column names by Xaml Language Dictionaries
		Method DgListView_MouseDoubleClick - Select and Open selected Record Detail
		Method DgListView_SelectionChanged - Select Record For control buttons enabling, show Report with join on Id

		Method BtnSave_Click    - Form to DataClassModel, send API (DB Insert/DB Update), Return to DataList View
		Method BtnCancel_Click  - Cancel Form and Return to DataListView
		Method SetRecord        - Load Selected Record (edit,copy) to Detail Form

		In Combined Forms with Subtable The methods Are copied as SubMethods (Translate,Data,Form Fields)

----
	
	Standartized SUBSELECT ComboBox/ListBox/ListView/Custom For Dial Join Record Selection (Addresses, Items, Etc.)

		Standartized Method List for Full Mouse/Keyboard Control
		- SelectGotFocus - Call SubDataList Controler for Selection one Record for Selection 'UpdateCustomerSearchResults'
		- UpdateCustomerSearchResults - Control full SubData List, select, show Info message not exist, Select Founded Record
		- Customer_KeyDown - Keyboard Up/Down Event for Data listing in ListView Form Item/Input
		- SelectCustomer_Enter - Selection by Enter
		- MouseSelectCustomer_Click - Selerction by Mouse
		- SetXxxxxx                 - Set Joined Fields From this Selection


----

		Standartized Methods For SubDocItems INSERT/DELETE (Invoice Example)
		- dgSubListView_SelectionChanged - Select Item form List For Delete Control
		- BtnItemInsert_Click            - Insert new Item to SubDataList from SubFormInputFields
		- BtnItemDelete_Click            - Delete selected SubItem from DataList
		- ClearItemsFields               - Clear SubItemForm
		- SetSubListsNonActiveOnNewItem  - Load Datasources For SubItem Selections types (Dials -> ItemList, CurrencyList)

		Optional 
		- HideTiltButtons                - Hide/Show Button for show subDocument
		- TiltToInvoice_Click            - Open subDocument

----
	
	Standartized Tilt Documents (Next Joined Generating SubDoc Offer -> Order, etc)
		
		Standartized Method List for full generation proccess
		- ImportInvoice - Import Existed Document (example in CreditNoteList)
	




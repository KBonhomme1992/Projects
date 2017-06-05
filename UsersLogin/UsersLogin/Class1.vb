Public Class SQLClass
    Private m_Server
    Private m_UserName
    Private m_PassWord
    Private m_DataBase
    Private m_Query
    Private m_Timeout
    Private objCon As New ADODB.Connection
    Private Rs1 As New ADODB.Command
    Private boolEOF As Boolean
    Private boolBOF As Boolean
    Private oconn
    Private orecordset As New ADODB.Recordset
    Private IsRecordSetOpen
    Private Errs1 As ADODB.Errors
    Private m_FieldType
    Private m_state
    Private m_status
    Private m_fieldstatus
    Private m_fieldattributes
    Public m_conn

    Public Sub Class_Initialize()
        m_Server = ""
        m_UserName = ""
        m_PassWord = ""
        m_DataBase = ""
        m_Query = ""
        m_Conn = ""
        m_Timeout = 36000
        boolEOF = True
        boolBOF = False
        oconn = False
        orecordset = Nothing
        m_FieldType = ""
        m_state = ""
        m_status = ""
        m_fieldstatus = ""
        m_fieldattributes = ""

        orecordset.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        orecordset.CursorType = ADODB.CursorTypeEnum.adOpenStatic
        orecordset.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic

    End Sub


    Private Sub Class_Terminate()
        If Not orecordset Is Nothing Then Call closeRecordSet()
        If Not oconn Is Nothing Then Call Close()
    End Sub

    Public Sub Open()
        objCon.CommandTimeout = m_Timeout
        objCon.Open("DRIVER={SQL Server};SERVER=" & m_Server & ";DATABASE=" & m_DataBase, m_UserName, m_PassWord)
        oconn = True
    End Sub

    Public Sub Close()
        If oconn Then objCon.Close
        oconn = False
    End Sub

    Public Sub OpenRecordSet()
        orecordset.Open(m_Query, objCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        IsRecordSetOpen = True
    End Sub

    Public Sub closeRecordSet()
        If Not IsRecordSetOpen Then orecordset.Close()
        IsRecordSetOpen = False
    End Sub


    Property GetRecordSet() As ADODB.Recordset
        Get
            Return Rs1(srecord)
        End Get
        Set(value As ADODB.Recordset)

        End Set
    End Property

    Public Property GetRecordSet(srecord)
	RecordSet = RS1(srecord)
   End Property

    Public Property GetField(ByVal sField)
	GetField = RS1.Fields(sField)
   End Property

    Public Property GetFieldValue(ByVal sField)
	GetFieldValue = RS1.Fields(sField).Value
   End Property

    Public Property Get GetFieldOriginalValue (ByVal sField)
	GetFieldOriginalValue = RS1.Fields(sField).OriginalValue
   End Property

    Public Property Get GetFieldUnderlyingValue (ByVal sField)
	GetFieldUnderlyingValue = RS1.Fields(sField).UnderlyingValue
   End Property

    Public Property Get GetFieldName (ByVal sField)
	GetFieldName = RS1.Fields(sField).Name
   End Property

    Public Property Get GetFieldActualSize (ByVal sField)
	GetFieldActualSize = RS1.Fields(sField).ActualSize
   End Property

    Public Property Get GetFieldDefinedSize (ByVal sField)
	GetFieldDefinedSize = RS1.Fields(sField).DefinedSize
   End Property

    Public Property Get GetFieldNumericScale (ByVal sField)
	GetFieldNumericScale = RS1.Fields(sField).NumericScale
   End Property

    Public Property Get GetFieldPrecision (ByVal sField)
	GetFieldPrecision = RS1.Fields(sField).Precision
   End Property

    Public Property Get GetFieldType (ByVal sField)
    Select Case RS1.Fields(sField).Type
    Case 0          'adEmpty	0	No value
			m_FieldType = "Empty"
			
		Case 2          'adSmallInt	2	A 2-byte signed integer.		
			m_FieldType = "SmallInt"
			
		Case 3          'adInteger	3	A 4-byte signed integer.		
			m_FieldType = "Integer"
			
		Case 4          'adSingle	4	A single-precision floating-point value.
			m_FieldType = "Single"
			
		Case 5          'adDouble	5	A double-precision floating-point value.
			m_FieldType = "Double"
			
		Case 6          'adCurrency	6	A currency value
			m_FieldType = "Currency"
			
		Case 7          'adDate	7	The number of days since December 30, 1899 + the fraction of a day.
			m_FieldType = "Date"
			
		Case 8          'adBSTR	8	A null-terminated character string.
			m_FieldType = "BSTR"
			
		Case 9          'adIDispatch	9	A pointer to an IDispatch interface on a COM object. Note: Currently not supported by ADO.
			m_FieldType = "IDispatch"
			
		Case 10         'adError	10	A 32-bit error code
			m_FieldType = "Error"
			
		Case 11         'adBoolean	11	A boolean value.
			m_FieldType = "Boolean"
			
		Case 12         'adVariant	12	An Automation Variant. Note: Currently not supported by ADO.
			m_FieldType = "Variant"
			
		Case 13         'adIUnknown	13	A pointer to an IUnknown interface on a COM object. Note: Currently not supported by ADO.	
			m_FieldType = "IUnknown"
			
		Case 14         'adDecimal	14	An exact numeric value with a fixed precision and scale.
			m_FieldType = "Decimal"
			
		Case 16         'adTinyInt	16	A 1-byte signed integer.
			m_FieldType = "TinyInt"
			
		Case 17         'adUnsignedTinyInt	17	A 1-byte unsigned integer.
			m_FieldType = "UnsignedTinyInt"
			
		Case 18         'adUnsignedSmallInt	18	A 2-byte unsigned integer.
			m_FieldType = "UnsignedSmallInt"
			
		Case 19         'adUnsignedInt	19	A 4-byte unsigned integer.
			m_FieldType = "UnsignedInt"
			
		Case 20         'adBigInt	20	An 8-byte signed integer.
			m_FieldType = "BigInt"
			
		Case 21         'adUnsignedBigInt	21	An 8-byte unsigned integer.
			m_FieldType = "UnsignedBigInt"
			
		Case 64         'adFileTime	64	The number of 100-nanosecond intervals since January 1,1601
			m_FieldType = "FileTime"
			
		Case 72         'adGUID	72	A globally unique identifier (GUID)
			m_FieldType = "GUID"
			
		Case 128        'adBinary	128	A binary value.
			m_FieldType = "Binary"
			
		Case 129        'adChar	129	A string value.
			m_FieldType = "Char"
			
		Case 130        'adWChar	130	A null-terminated Unicode character string.
			m_FieldType = "WChar"
			
		Case 131        'adNumeric	131	An exact numeric value with a fixed precision and scale.
			m_FieldType = "Numeric"
			
		Case 132        'adUserDefined	132	A user-defined variable.
			m_FieldType = "UserDefined"
			
		Case 133        'adDBDate	133	A date value (yyyymmdd).
			m_FieldType = "DBDate"
			
		Case 134        'adDBTime	134	A time value (hhmmss).
			m_FieldType = "DBTime"
			
		Case 135        'adDBTimeStamp	135	A date/time stamp (yyyymmddhhmmss plus a fraction in billionths).
			m_FieldType = "DBTimeStamp"
			
		Case 136        'adChapter	136	A 4-byte chapter value that identifies rows in a child rowset
			m_FieldType = "Chapter"
			
		Case 138        'adPropVariant	138	An Automation PROPVARIANT.
			m_FieldType = "PropVariant"
			
		Case 139        'adVarNumeric	139	A numeric value (Parameter object only).
			m_FieldType = "VarNumeric"
			
		Case 200        'adVarChar	200	A string value (Parameter object only).
			m_FieldType = "VarChar"
			
		Case 201        'adLongVarChar	201	A long string value.
			m_FieldType = "LongVarChar"
			
		Case 202        'adVarWChar	202	A null-terminated Unicode character string.
			m_FieldType = "VarWChar"
			
		Case 203        'adLongVarWChar	203	A long null-terminated Unicode string value.
			m_FieldType = "LongVarWChar"
			
		Case 204        'adVarBinary	204	A binary value (Parameter object only).
			m_FieldType = "VarBinary"
			
		Case 205        'adLongVarBinary	205	A long binary value.
			m_FieldType = "LongVarBinary"
			
		Case 2000       'AdArray	0x2000	A flag value combined with another data type constant. Indicates an array of that other data type.
			m_FieldType = "Array"
			
		Case Else
			m_FieldType = "N/A"
			
	End Select
	GetFieldType = m_FieldType
   End Property

    Public Property Get GetFieldStatus (ByVal sField)
    Select Case RS1.Fields(sField).Status
    Case 0              'adFieldOK	0	Default. The field was successfully added or deleted
			m_fieldstatus = "The field was successfully added or deleted"	
		
		Case 2              'adFieldCantConvertValue	2	The field cannot be retrieved or stored without loss of data
			m_fieldstatus = "The field cannot be retrieved or stored without loss of data"
			
		Case 3              'adFieldIsNull	3	The provider returned a null value
			m_fieldstatus = "The provider returned a null value"

		Case 4              'adFieldTruncated	4	Variable-length data was truncated when reading from the data source
			m_fieldstatus = "Variable-length data was truncated when reading from the data source"
			
		Case 5              'adFieldSignMismatch	5	The data value returned by the provider was signed, but the data type of the ADO field value was unsigned
			m_fieldstatus = "The data value returned by the provider was signed, but the data type of the ADO field value was unsigned"

		Case 6              'adFieldDataOverflow	6	The data returned from the provider overflowed the data type of the field
			m_fieldstatus = "The data returned from the provider overflowed the data type of the field"

		Case 7              'adFieldCantCreate	7	The field could not be added because the provider exceeded a limitation
			m_fieldstatus = "The field could not be added because the provider exceeded a limitation"
			
		Case 8              'adFieldUnavailable	8	The provider could not determine the value when reading from the data source
			m_fieldstatus = "The provider could not determine the value when reading from the data source"
			
		Case 9              'adFieldPermissionDenied	9	The field cannot be modified because it is read-only
			m_fieldstatus = "The field cannot be modified because it is read-only"
			
		Case 10             'adFieldIntegrityViolation	10	The field cannot be modified because it is a calculated or derived entity
			m_fieldstatus = "The field cannot be modified because it is a calculated or derived entity"
			
		Case 11             'adFieldSchemaViolation	11	The value violated the data source schema constraint for the field
			m_fieldstatus = "The value violated the data source schema constraint for the field"
			
		Case 12             'adFieldBadStatus	12	An invalid status value was sent from ADO to the OLE DB provider
			m_fieldstatus = "An invalid status value was sent from ADO to the OLE DB provider"
			
		Case 13             'adFieldDefault	13	The default value for the field was used when setting data
			m_fieldstatus = "The default value for the field was used when setting data"
			
		Case 15             'adFieldIgnore	15	This field was skipped when setting data values in the source
			m_fieldstatus = "This field was skipped when setting data values in the source"
			
		Case 16             'adFieldDoesNotExist	16	The field does not exist
			m_fieldstatus = "The field does not exist"
			
		Case 17             'adFieldInvalidURL	17	The data source URL contains invalid characters
			m_fieldstatus = "The data source URL contains invalid characters"
			
		Case 18             'adFieldResourceLocked	18	The provider cannot perform the operation because the data source is locked
			m_fieldstatus = "The provider cannot perform the operation because the data source is locked"
			
		Case 19             'adFieldResourceExists	19	The provider cannot perform the operation because an object already exists at the destination URL and it is not able to overwrite the object
			m_fieldstatus = "The provider cannot perform the operation because an object already exists at the destination URL and it is not able to overwrite the object"
			
		Case 20             'adFieldCannotComplete	20	The server of the URL specified by Source could not complete the operation
			m_fieldstatus = "The server of the URL specified by Source could not complete the operation"
			
		Case 21             'adFieldVolumeNotFound	21	The provider is unable to locate the storage volume indicated by the URL
			m_fieldstatus = "The provider is unable to locate the storage volume indicated by the URL"
			
		Case 22             'adFieldOutOfSpace	22	The provider is unable to obtain enough storage space to complete a move or copy operation
			m_fieldstatus = "The provider is unable to obtain enough storage space to complete a move or copy operation"
			
		Case 23             'adFieldCannotDeleteSource	23	During a move operation, a tree or subtree was moved to a new location, but the source could not be deleted
			m_fieldstatus = "During a move operation, a tree or subtree was moved to a new location, but the source could not be deleted"
			
		Case 24             'adFieldReadOnly	24	The field in the data source is read-only
			m_fieldstatus = "The field in the data source is read-only"
			
		Case 25             'adFieldResourceOutOfScope	25	A source or destination URL is outside the scope of the current record
			m_fieldstatus = "A source or destination URL is outside the scope of the current record"
			
		Case 26             'adFieldAlreadyExists	26	The specified field already exists
			m_fieldstatus = "The specified field already exists"
			
		Case &H10000        'adFieldPendingInsert	0x10000	The Append operation caused the status to be set. The field has been marked to be added to the Fields collection after the Update method is called
			m_fieldstatus = "The Append operation caused the status to be set. The field has been marked to be added to the Fields collection after the Update method is called"
			
		Case &H20000        'adFieldPendingDelete	0x20000	The Delete operation caused the status to be set. The field has been marked for deletion from the Fields collection after the Update method is called
			m_fieldstatus = "The Delete operation caused the status to be set. The field has been marked for deletion from the Fields collection after the Update method is called"
			
		Case &H40000        'adFieldPendingChange	0x40000	The field has been deleted and then re-added or the value of the field which previously had a status of adFieldOK has changed
			m_fieldstatus = "The field has been deleted and then re-added or the value of the field which previously had a status of adFieldOK has changed"
			
		Case &H80000        'adFieldPendingUnknown	0x80000	The provider cannot determine what operation caused field status to be set
			m_fieldstatus = "The provider cannot determine what operation caused field status to be set"
			
		Case &H100000       'adFieldPendingUnknownDelete	0x100000	The provider cannot determine what operation caused field status to be set, and that the field will be deleted from the Fields collection after the Update method is called.
			m_fieldstatus = "The provider cannot determine what operation caused field status to be set, and that the field will be deleted from the Fields collection after the Update method is called."
			
		Case Else
			m_fieldstatus = "N/A"
			
	End Select
	GetFieldStatus = m_fieldstatus
   End Property

    Public Property Get GetFieldAttributes (ByVal sField)
    Select Case RS1.Fields(sField).Attributes
    Case &H2        'adFldMayDefer	0x2	Field values are not retrieved from the data source with the whole record, but only when you explicitly access them.
			m_fieldattributes = "Field values are not retrieved from the data source with the whole record, but only when you explicitly access them."

		Case &H4        'adFldUpdatable	0x4	You can write to the field.
			m_fieldattributes = "You can write to the field."

		Case &H8        'adFldUnknownUpdatable	0x8	The provider cannot determine if you can write to the field.
			m_fieldattributes = "The provider cannot determine if you can write to the field."

		Case &H10       'adFldFixed	0x10	Field contains fixed-length data.
			m_fieldattributes = "Field contains fixed-length data."

		Case &H20       'adFldIsNullable	0x20	Field accepts null values.
			m_fieldattributes = "Field accepts null values."

		Case &H40       'adFldMayBeNull	0x40	You can read null values from the field.
			m_fieldattributes = "You can read null values from the field."

		Case &H80       'adFldLong	0x80	Field is a long binary field.
			m_fieldattributes = "Field is a long binary field."

		Case &H100      'adFldRowID	0x100	Field contains a persistent row identifier that cannot be written to and has no meaningful value except to identify the row (such as a unique id)
			m_fieldattributes = "Field contains a persistent row identifier that cannot be written to and has no meaningful value except to identify the row (such as a unique id)"

		Case &H200      'adFldRowVersion	0x200	Field contains some kind of time/date stamp used to track updates.
			m_fieldattributes = "Field contains some kind of time/date stamp used to track updates."

		Case &H1000     'adFldCacheDeferred	0x1000	Provider caches the field values and reads from the cache.
			m_fieldattributes = "Provider caches the field values and reads from the cache."

		Case &H2000     'adFldIsChapter	0x2000	Field contains a chapter value that specifies a child recordset.
			m_fieldattributes = "Field contains a chapter value that specifies a child recordset."

		Case &H4000     'adFldNegativeScale	0x4000	Field represents a numeric value from a column that supports negative scale values.
			m_fieldattributes = "Field represents a numeric value from a column that supports negative scale values."

		Case &H10000    'adFldIsRowURL	0x10000	Field contains the URL that names the resource from the data store represented by the record.
			m_fieldattributes = "Field contains the URL that names the resource from the data store represented by the record."

		Case &H20000    'adFldIsDefaultStream	0x20000	Field contains the default stream for the resource represented by the record.
			m_fieldattributes = "Field contains the default stream for the resource represented by the record."

		Case &H40000    'adFldIsCollection	0x40000	The field specifies that the resource represented by the record is a collection of  resources
			m_fieldattributes = "The field specifies that the resource represented by the record is a collection of  resources"

		Case &HFFFFFFFF 'adFldUnspecified	 -1 0xFFFFFFFF	Provider does not specify the field attributes.
			m_fieldattributes = "Provider does not specify the field attributes."

		Case -1         'adFldUnspecified	 -1 0xFFFFFFFF	Provider does not specify the field attributes.
			m_fieldattributes = "Provider does not specify the field attributes."

		Case Else
			m_fieldattributes = "N/A"
		
	End Select
	GetFieldAttributes = m_fieldattributes
   End Property

    Public Sub MoveNext()
        boolEOF = Flase
        boolBOF = Flase
        Rs1.MoveNext
        If Rs1.EOF Then boolEOF = True
        If Rs1.BOF Then boolBOF = True
    End Sub

    Public Sub MovePrev()
        boolEOF = Flase
        boolBOF = Flase
        Rs1.MovePrev
        If Rs1.EOF Then boolEOF = True
        If Rs1.BOF Then boolBOF = True
    End Sub

    Public Sub MoveFirst()
        boolEOF = Flase
        Rs1.MoveFirst
        If Rs1.EOF Then boolEOF = True
    End Sub

    Public Sub MoveLast()
        boolEOF = Flase
        Rs1.MoveLast
        If Rs1.EOF Then boolEOF = True
    End Sub

    Public Property Get Server
      Server = m_Server
   End Property

    Public Property Let Server(ByVal sname)
      m_Server = sname
   End Property

    Public Property Get UserName
      UserName = m_UserName
   End Property

    Public Property Let UserName(ByVal uname)
      m_UserName = uname
   End Property

    Public Property Get PassWord
      PassWord = m_PassWord
   End Property

    Public Property Let PassWord(ByVal pass)
      m_PassWord = pass
   End Property

    Public Property Get DataBase
      DataBase = m_DataBase
   End Property

    Public Property Let DataBase(ByVal DB)
      m_DataBase = DB
   End Property

    Public Property Get Query
      Query = m_Query
   End Property

    Public Property Let Query(ByVal squery)
      m_Query = squery
   End Property

    Public Property Get Timeout
      Timeout = m_Timeout
   End Property

    Public Property Let Timeout(ByVal time)
      m_Timeout = time
   End Property

    Public Property Get EOF
	boolEOF = Flase
	If RS1.EOF Then boolEOF = True
	EOF = boolEOF
   End Property

    Public Property Get BOF
	boolBOF = Flase
	If RS1.BOF Then boolBOF = True
	BOF = boolBOF
   End Property

    Public Property Get FieldsCount 
	FieldsCount = RS1.Fields.Count
   End Property

    Public Property Get RecordCount 
	RecordCount = RS1.RecordCount 
   End Property

    Public Property Get Status 

	Select Case RS1.Status
    Case 0          'adRecOK	0	Record successfully updated
			m_status = "Record successfully updated"
			
		Case &H1        'adRecNew	0x1	Record is new
			m_status = "Record is new"
			
		Case &H2        'adRecModified	0x2	Record modified
			m_status = "Record modified"
			
		Case &H4        'adRecDeleted	0x4	Record deleted
			m_status = "Record deleted"
			
		Case &H8        'adRecUnmodified	0x8	Record not modified
			m_status = "Record not modified"
			
		Case &H10       'adRecInvalid	0x10	Record not saved; invalid bookmark
			m_status = "Record not saved; invalid bookmark"
			
		Case &H40       'adRecMultipleChanges	0x40	Record not saved; would have affected multiple records
			m_status = "Record not saved; would have affected multiple records"
			
		Case &H80       'adRecPendingChanges	0x80	Record not saved; refers to a pending insert
			m_status = "Record not saved; refers to a pending insert"
			
		Case &H100      'adRecCanceled	0x100	Record not saved; operation was canceled
			m_status = "Record not saved; operation was canceled"
			
		Case &H400      'adRecCantRelease	0x400	New record not saved; existing record was locked
			m_status = "New record not saved; existing record was locked"
			
		Case &H400      'adRecConcurrencyViolation	0x800	Record not saved; optimistic concurrency was in use
			m_status = "Record not saved; optimistic concurrency was in use"
			
		Case &H1000     'adRecIntegrityViolation	0x1000	Record not saved; user violated integrity constraints
			m_status = "Record not saved; user violated integrity constraints"
			
		Case &H2000     'adRecMaxChangesExceeded	0x2000	Record not saved; too many pending changes
			m_status = "Record not saved; too many pending changes"
			
		Case &H4000     'adRecObjectOpen	0x4000	Record not saved; conflict with an open storage object
			m_status = "Record not saved; conflict with an open storage object"
			
		Case &H8000     'adRecOutOfMemory	0x8000	Record not saved; computer has run out of memory
			m_status = "Record not saved; computer has run out of memory"
			
		Case &H10000    'adRecPermissionDenied	0x10000	Record not saved; user has insufficient permissions
			m_status = "Record not saved; user has insufficient permissions"
			
		Case &H20000    'adRecSchemaViolation	0x20000	Record not saved; violates the structure of the database
			m_status = "Record not saved; violates the structure of the database"
			
		Case &H40000    'adRecDBDeleted	0x40000	Record already deleted from the data source	
			m_status = "Record already deleted from the data source"
			
		Case Else
			m_status = "N/A"
	End Select
	Status= m_status
   End Property

    Public Property Get State 
	State = RS1.State
	Select Case RS1.State
    Case 0      'adStateClosed	0	The object is closed
			m_state = "Close"
			
		Case 1      'adStateOpen	1	The object is open
			m_state = "Open"
			
		Case 2      'adStateConnecting	2	The object is connecting
			m_state = "Connecting"
			
		Case 4      'adStateExecuting	4	The object is executing a command
			m_state = "Executing"
			
		Case 8      'adStateFetching	8	The rows of the object are being retrieved
			m_state = "Fetching"
			
		Case Else
			m_state = "N/A"
			
	End Select
	
	State = m_state
   End Property




End Class

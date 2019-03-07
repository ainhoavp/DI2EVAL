# Instalador que nos pregunta donde queremos instalar
# Ruta por defecto: archivos de programa
# Incluye informacion sobre la desisntalacion

# Nombre del instalador
Name "Instalador Corredores"

# The file to write #como se va a llamar el instalador
OutFile "GestionCorredores.exe"

# The default installation directory
InstallDir $PROGRAMFILES\Corredores
#este instala en archivos de programa que es $PROGRAMFILES y pro eso en la linea de abajo se pone admin en vez de user, porque toca archivos del sistema.

# Pedimos permisos para Windows 7
RequestExecutionLevel admin

# Pantallas que hay que mostrar del instalador

Page directory
Page instfiles

#Seccion principal
Section




  # Establecemos el directorio de salida al directorio de instalacion
  SetOutPath $INSTDIR
  
  
   
  
  
  
  # Creamos el desinstalador
  writeUninstaller "$INSTDIR\uninstall.exe"
  
  # Ponemos ahi el archivo test.txt
  File "Corredores.jar"
  File /r "lib"
  File /r "informes"
  File /r "help"
  
   # Creamos un acceso directo apuntando al desinstalador esto crea un acceso directo en el escritorio que se llama corredor.lnk y apunta a corredores.jar
   
    createShortCut "$DESKTOP\Corredor.lnk" "$INSTDIR\Corredores.jar"
  
  #Añadimos información para que salga en el menú de desinstalar de Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Corredores" \
                 "DisplayName" "Corredores"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Corredores" \
                 "Publisher" "Ainhoa - Desarrollo Interfaces"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Corredores" \
                 "UninstallString" "$\"$INSTDIR\uninstall.exe$\""

				 
#aqui escribimos 3 cosas en el registro de windows para decirle que desde "quitar progamas" enlazaremos con nuestro desinstalador. 
#Añade la app a la lista de aplica. de windows.
  
# Fin de la seccion
SectionEnd

# seccion del desintalador
section "uninstall"
 
    # borramos el desintalador primero
    delete "$INSTDIR\uninstall.exe"
 
    # borramos la aplicación
    delete "$INSTDIR\Corredores.jar"
	RmDir /r "$INSTDIR\lib"
	RmDir /r "$INSTDIR\informes"
	RmDir /r "$INSTDIR\help"
	delete corredores.csv
	delete datosCarrera.data
	delete datosCorredores.data
	#borramos  acceso directo.
	delete "$DESKTOP\Corredor.lnk"

	RmDir "$INSTDIR" #borra el directorio de instalación.
	#PROBLEMA: esto borra un directorio (normalmente solo directorios vacíos) la practica correcta es borrar todo y después borrar el directorio vacio.
	#NUNCA USAR A ORDEN DE BORRAR DIRECTORIOS CON COSAS DENTRO porque puede que el usuario se cargue archivos de sistema y se fume windows.
	#Usar esta orden SOLO cuando el directorio esté vacío, es decir depués de haber borrado todo lo que está dentro primero.
	
	#Borramos la entrada del registro
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Corredores" #borra todo lo que habíamos escrito en el registro.
 
# fin de la seccion del desinstalador
sectionEnd
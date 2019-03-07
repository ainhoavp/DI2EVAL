# Instalador que nos pregunta donde queremos instalar
# Ruta por defecto: archivos de programa
# Incluye informacion sobre la desisntalacion

# Nombre del instalador
Name "Instalador Avituallamientos"

# The file to write
OutFile "AppAvituallamientos.exe"

# The default installation directory
InstallDir $PROGRAMFILES\Avituallamientos
#este instala en archivos de programa que es $PROGRAMFILES y pro eso en la linea de abajo se pone admin en vez de user, porque toca archivos del sistema.

# Pedimos permisos para Windows 7
RequestExecutionLevel admin

# Pantallas que hay que mostrar del instalador

Page directory
Page instfiles


#español

!include "MUI.nsh"

!insertmacro MUI_LANGUAGE "Spanish"


#Seccion principal
Section

  # Establecemos el directorio de salida al directorio de instalacion
  SetOutPath $INSTDIR
  
  # Creamos el desinstalador
  writeUninstaller "$INSTDIR\uninstall.exe"
  
  # Ponemos ahi el archivo test.txt
  File "GestionAvituallamientos.exe"
  
  #con esto creamos un acceso directo en el escritorio.

  createShortCut "$DESKTOP\GestionAvituallamientos.lnk" "$INSTDIR\GestionAvituallamientos.exe"
  
  
  
  #Añadimos información para que salga en el menú de desinstalar de Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Avituallamientos" \
                 "DisplayName" "Avituallamientos"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Avituallamientos" \
                 "Publisher" "Ainhoa - Desarrollo Interfaces"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Avituallamientos" \
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
    delete "$INSTDIR\GestionAvituallamientos.exe"
	delete "$DESKTOP\GestionAvituallamientos.lnk"

	
	
	RmDir "$INSTDIR" #borra el directorio de instalación.
	#PROBLEMA: esto borra un directorio (normalmente solo directorios vacíos) la practica correcta es borrar todo y después borrar el directorio vacio.
	#NUNCA USAR A ORDEN DE BORRAR DIRECTORIOS CON COSAS DENTRO porque puede que el usuario se cargue archivos de sistema y se fume windows.
	#Usar esta orden SOLO cuando el directorio esté vacío, es decir depués de haber borrado todo lo que está dentro primero.
	
	#Borramos la entrada del registro
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Avituallamientos"
	#borra todo lo que habíamos escrito en el registro.
 
# fin de la seccion del desinstalador
sectionEnd
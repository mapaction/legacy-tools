# ---------------------------------------------------------------------------
# Cookie.py
# Created on: Tue Jan 22 2008 09:34:56 PM
#   (generated by ArcGIS/ModelBuilder)
# Usage: Cookie Setup
# 1. Set the two variables below. These are the main project directory (note the double slash) and input shapefile.
# 2. The script creates two new subdirectories: "input" and "output"
# 2. The script adds a *new* field called BACKGROUND to the input shapefile. ALL rows have the same preset value of "-32768" added.
# 3. The SplitLayerByAttributes script splits the single shapefile into multiple files, placing them all in the "input" directory
# ---------------------------------------------------------------------------

# Import system modules
import sys, string, os, arcgisscripting,glob
import struct, datetime, decimal, itertools, csv

# Create the Geoprocessor object
gp = arcgisscripting.create()
gp.overwriteoutput = 1

#-----------------------------------------------------------------------------
# Variables
#-----------------------------------------------------------------------------
#project_directory = "C:\\temp\\cookie\\"
#outlines = "C:\\temp\\cookie\\case1.shp"
project_directory = sys.argv[1]
outlines = sys.argv[2]
#-----------------------------------------------------------------------------

# change to directory
os.chdir(project_directory)

# Make program directories
dirname = "input"
if not os.path.isdir("./" + dirname + "/"):
    os.mkdir("./" + dirname + "/")

dirname = "output"
if not os.path.isdir("./" + dirname + "/"):
    os.mkdir("./" + dirname + "/")

dirname = "temp"
if not os.path.isdir("./" + dirname + "/"):
    os.mkdir("./" + dirname + "/")

gp.scratchWorkspace = project_directory +"\\temp"

# Add BACKGROUND field and value
if not gp.listFields(outlines,"BACKGROUND").Next():
    gp.AddField(outlines,"BACKGROUND","long")
gp.CalculateField_management(outlines, "BACKGROUND", "-32768", "VB")

# Split shapefile (sys.path is 3 when run from IDLE and 0 from ArcMap or is it?!)
#print sys.path
toolbox_path = sys.path[0]+"\\CookieCutter.tbx"
gp.AddToolbox(toolbox_path)
gp.SplitLayerByAttributes(outlines, "FID", "A",project_directory +"\\input") 
#!/usr/bin/python
# -*- coding: utf-8 -*-

import sys
import ntpath
from jinja2 import Template, Environment, FileSystemLoader, UndefinedError
import json

templateIdentity = sys.argv[1]
templatePath = sys.path[0]

env = Environment(loader=FileSystemLoader(templatePath))
template = env.get_template(templateIdentity)

# Read all contexts from the file
with open(templateIdentity+".json") as json_file:
    ctxList = json.load(json_file)

try:

    # For each context render templates
    for ctx in ctxList:
        outputFilename = ntpath.dirname(
            templateIdentity) + "/" + ctx["fileName"]
        print("{template} + {template}.json => {output}".format(
            template=templateIdentity, output=outputFilename))

        res = template.render(ctx, templateFileName=templateIdentity)
        with open(outputFilename, "w") as file:
            file.write(res)

except KeyError as e:
    print "Required key '{key}' is not defined in this context:\r\n {ctx}".format(
        key=e.message, ctx=ctx)
    sys.exit(1)
except UndefinedError as e:
    print "Key {key}, but used in template. Context:\r\n {ctx}".format(
        key=e.message, ctx=ctx)
    sys.exit(2)

add_library(ImGuiLib STATIC)

target_sources(ImGuiLib PRIVATE
        imgui.cpp
        imgui_demo.cpp
        imgui_draw.cpp
        imgui_tables.cpp
        imgui_widgets.cpp
)

target_include_directories(ImGuiLib PUBLIC
        ${CMAKE_CURRENT_SOURCE_DIR}
)
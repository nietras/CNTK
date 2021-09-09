#pragma once

#ifdef _WIN32
#ifdef NMS_LIBRARY
#define NMS_API __declspec(dllexport)
#else
#define NMS_API __declspec(dllimport)
#endif
#define _SCL_SECURE_NO_WARNINGS
#else // no DLLs on Linux
#define CNTK_API
#endif

// 2021.09.06 - sigfrid696
// NMS GPU implementation 

// fyk:params is all cpu memory var, boxes_dim should be 4 instead of 5(x1,y1,x2,y2,confidence),the boxes_host should have already sorted by confidence from big to little
NMS_API void _nms(int* keep_out, int* num_out, const float* boxes_host, int boxes_num,
          int boxes_dim, float nms_overlap_thresh, int device_id = -1);


